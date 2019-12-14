using System;
using System.Collections.Generic;
using System.IO;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer
    {
        private MLContext mlContext;

        public RFMKMeanAnalyzer(MLContext mlContext)
        {
            this.mlContext = mlContext;
        }

        public List<RFMSubscriber> Analyze(List<RFMSubscriber> subscribers, string subscriberRateClass)
        {
            var loadedModel = LoadModel();

            var rfmSubscribers = new List<RFMSubscriber>();

            foreach (var subscriber in subscribers)
            {
                var input = CreateInputModel(subscriber);

                var outputLabel = Predict(loadedModel, input);

                subscriber.RFMClass = outputLabel;

                if (OutputIsGood(subscriber, subscriberRateClass))
                {
                    rfmSubscribers.Add(subscriber);
                }
            }

            return rfmSubscribers;
        }

        private string Predict(ITransformer loadedModel, InputRFMSubscriber input)
        {
            var predEngine = mlContext.Model.CreatePredictionEngine<InputRFMSubscriber, OutputRFMCustomer>(loadedModel);

            var prediction = predEngine.Predict(input);

            return prediction.RFMClass;
        }

        private InputRFMSubscriber CreateInputModel(RFMSubscriber rfmSubscriber)
        {
            var inputRFMSubscriber = new InputRFMSubscriber
            {
                Recency = rfmSubscriber.Recency.Value,
                Frequency = rfmSubscriber.Frequency.Value,
                Monetary = rfmSubscriber.Monetary.Value,
            };

            return inputRFMSubscriber;
        }

        private bool OutputIsGood(RFMSubscriber output, string subscriberRateClass)
        {
            return output.RFMClass.Equals(subscriberRateClass);
        }

        private ITransformer LoadModel()
        {
            string _appPath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            string _modelPath = Path.Combine(_appPath, "..", "..", "..", "ML.Models", "model.zip");

            ITransformer loadedModel = mlContext.Model.Load(_modelPath, out var modelInputSchema);

            return loadedModel;
        }
    }

    internal class OutputRFMCustomer
    {
        [ColumnName("PredictedLabel")]
        public string RFMClass { get; set; }
    }

    internal class InputRFMSubscriber
    {
        [LoadColumn(5)]
        public float Frequency { get; set; }

        [LoadColumn(6)]
        public float Recency { get; set; }

        [LoadColumn(7)]
        public float Monetary { get; set; }

        [LoadColumn(11)]
        public string RFMClass { get; set; }
    }
}