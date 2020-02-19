using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMSubscriberParser : SubscriberParser
    {
        #region Overrides of SubscriberParser

        public override List<RFMSubscriber> Parse(string subscribers)
        {
            //Create MLContext
            MLContext mlContext = new MLContext();
            string _appPath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            string _modelPath = Path.Combine(_appPath, "..", "..", "..", "m", "MLModel.zip");
            // Load Trained Model
            DataViewSchema predictionPipelineSchema;
            ITransformer predictionPipeline = mlContext.Model.Load(_modelPath, out predictionPipelineSchema);
            PredictionEngine<Input, Output> predictionEngine = mlContext.Model.CreatePredictionEngine<Input, Output>(predictionPipeline);

            var subscribersInfo = subscribers.Split("\r");

            return subscribersInfo.Select(subscriberInfo => subscriberInfo.Split(","))
                .Select(info => new RFMSubscriber()
                {
                    Name = info[0].Trim(),
                    Email = info[1].Trim(),
                    Phone = info[2].Trim(),
                    Monetary = string.IsNullOrEmpty(info[3].Trim()) ? 0 : float.Parse(info[3].Trim()),
                    Recency = string.IsNullOrEmpty(info[4].Trim()) ? 0 : float.Parse(info[4].Trim()),
                    Frequency = string.IsNullOrEmpty(info[5].Trim()) ? 0 : float.Parse(info[5].Trim()),
                    RFMClass = predictionEngine.Predict(new Input
                    {
                        UnitPrice = string.IsNullOrEmpty(info[3].Trim()) ? 0 : float.Parse(info[3].Trim()),
                        recency = string.IsNullOrEmpty(info[4].Trim()) ? 0 : float.Parse(info[4].Trim()),
                        freq = string.IsNullOrEmpty(info[5].Trim()) ? 0 : float.Parse(info[5].Trim())
                    }).Type
                })
                .ToList();
        }

        #endregion Overrides of SubscriberParser
    }

    internal class Output
    {
        [ColumnName("PredictedLabel")]
        public string Type { get; set; }
    }

    internal class Input
    {
        [LoadColumn(11)]
        public string Type { get; set; }

        [LoadColumn(7)]
        public float UnitPrice { get; set; }

        [LoadColumn(8)]
        public float recency { get; set; }

        [LoadColumn(9)]
        public float freq { get; set; }
    }
}