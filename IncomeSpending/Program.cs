using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace IncomeSpending
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "Mall_Customers.csv");
            string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Mall_Customers.zip");

            var mlContext = new MLContext(seed: 0);
            IDataView dataView = mlContext.Data.LoadFromTextFile<Input>(_dataPath, hasHeader: true, separatorChar: ',');
            string featuresColumnName = "Features";
            var pipeline = mlContext.Transforms
                .Concatenate(featuresColumnName, "Income", "Spending")
                .Append(mlContext.Clustering.Trainers.KMeans(featuresColumnName, numberOfClusters: 5));
            var model = pipeline.Fit(dataView);
            using (var fileStream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                mlContext.Model.Save(model, dataView.Schema, fileStream);
            }
            var predictor = mlContext.Model.CreatePredictionEngine<Input, ClusterPrediction>(model);

            var prediction = predictor.Predict(new Input { Income = 100, Spending = 10 });

            Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
            Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances)}");

            Console.ReadLine();
        }
    }

    public class TestIrisData
    {
        //public static Input Setosa = new Input
        //{
        //    SepalLength = 5.1f,
        //    SepalWidth = 3.5f,
        //    PetalLength = 1.4f,
        //    PetalWidth = 0.2f
        //};
    }

    public class Input
    {
        [LoadColumn(3)]
        public float Income;

        [LoadColumn(4)]
        public float Spending;
    }

    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
}