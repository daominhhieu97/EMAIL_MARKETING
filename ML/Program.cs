using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace ML
{
    internal class Program
    {
        // <SnippetDeclareGlobalVariables>
        private static string _appPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

        private static string _trainDataPath => Path.Combine(_appPath, "..", "..", "..", "Data", "data.csv");
        private static string _modelPath => Path.Combine(_appPath, "..", "..", "..", "Models", "model.zip");

        private static MLContext _mlContext;
        private static PredictionEngine<Input, Output> _predEngine;
        private static ITransformer _trainedModel;
        private static IDataView _trainingDataView;

        // </SnippetDeclareGlobalVariables>
        private static void Main(string[] args)
        {
            // Create MLContext to be shared across the model creation workflow objects
            // Set a random seed for repeatable/deterministic results across multiple trainings.
            // <SnippetCreateMLContext>
            _mlContext = new MLContext(seed: 0);
            // </SnippetCreateMLContext>

            // STEP 1: Common data loading configuration
            // CreateTextReader<GitHubIssue>(hasHeader: true) - Creates a TextLoader by inferencing the dataset schema from the GitHubIssue data model type.
            // .Read(_trainDataPath) - Loads the training text file into an IDataView (_trainingDataView) and maps from input columns to IDataView columns.
            Console.WriteLine($"=============== Loading Dataset  ===============");

            // <SnippetLoadTrainData>
            _trainingDataView = _mlContext.Data.LoadFromTextFile<Input>(_trainDataPath, ',', hasHeader: true);
            // </SnippetLoadTrainData>

            Console.WriteLine($"=============== Finished Loading Dataset  ===============");

            // <SnippetCallProcessData>
            var pipeline = ProcessData();
            // </SnippetCallProcessData>

            // <SnippetCallBuildAndTrainModel>
            var trainingPipeline = BuildAndTrainModel(_trainingDataView, pipeline);
            // </SnippetCallBuildAndTrainModel>

            SaveModelAsFile(_mlContext, _trainingDataView.Schema, _trainedModel);
            // <SnippetCallPredictIssue>
            //PredictOutput();
            // </SnippetCallPredictIssue>
        }

        public static IEstimator<ITransformer> ProcessData()
        {
            Console.WriteLine($"=============== Processing Data ===============");
            // STEP 2: Common data process configuration with pipeline data transformations
            // <SnippetMapValueToKey>
            var pipeline = _mlContext.Transforms.Conversion
                .MapValueToKey(inputColumnName: "Type", outputColumnName: "Label")
                // </SnippetFeaturizeText>
                // <SnippetConcatenate>
                .Append(_mlContext.Transforms.Concatenate("Features", new[] { "M", "R", "F" }));
            // </SnippetAppendCache>

            Console.WriteLine($"=============== Finished Processing Data ===============");

            // <SnippetReturnPipeline>
            return pipeline;
            // </SnippetReturnPipeline>
        }

        public static IEstimator<ITransformer> BuildAndTrainModel(IDataView trainingDataView, IEstimator<ITransformer> pipeline)
        {
            // STEP 3: Create the training algorithm/trainer
            // Use the multi-class SDCA algorithm to predict the label using features.
            //Set the trainer/algorithm and map label to value (original readable state)
            // <SnippetAddTrainer>
            var trainingPipeline = pipeline.Append(_mlContext.MulticlassClassification.Trainers.LightGbm("Label", "Features"))
                    .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));
            // </SnippetAddTrainer>

            // STEP 4: Train the model fitting to the DataSet
            Console.WriteLine($"=============== Training the model  ===============");

            // <SnippetTrainModel>
            _trainedModel = trainingPipeline.Fit(trainingDataView);
            // </SnippetTrainModel>
            Console.WriteLine($"=============== Finished Training the model Ending time: {DateTime.Now.ToString()} ===============");

            // (OPTIONAL) Try/test a single prediction with the "just-trained model" (Before saving the model)
            Console.WriteLine($"=============== Single Prediction just-trained-model ===============");

            // Create prediction engine related to the loaded trained model
            // <SnippetCreatePredictionEngine1>
            _predEngine = _mlContext.Model.CreatePredictionEngine<Input, Output>(_trainedModel);
            // </SnippetCreatePredictionEngine1>
            // <SnippetCreateTestIssue1>
            Input input = new Input()
            {
                M = 100000000,
                R = 100,
                F = 20
            };
            // </SnippetCreateTestIssue1>

            // <SnippetPredict>
            var prediction = _predEngine.Predict(input);
            // </SnippetPredict>

            // <SnippetOutputPrediction>
            Console.WriteLine($"=============== Single Prediction just-trained-model - Result: {prediction.Type} ===============");
            // </SnippetOutputPrediction>

            // <SnippetReturnModel>
            return trainingPipeline;
            // </SnippetReturnModel>
        }

        public static void PredictOutput()
        {
            // <SnippetLoadModel>
            ITransformer loadedModel = _mlContext.Model.Load(_modelPath, out var modelInputSchema);
            // </SnippetLoadModel>

            // <SnippetAddTestIssue>
            Input singleIssue = new Input()
            {
                R = 1,
                F = 1,
                M = 1
            };
            // </SnippetAddTestIssue>

            //Predict label for single hard-coded issue
            // <SnippetCreatePredictionEngine>
            _predEngine = _mlContext.Model.CreatePredictionEngine<Input, Output>(loadedModel);
            // </SnippetCreatePredictionEngine>

            // <SnippetPredictIssue>
            var prediction = _predEngine.Predict(singleIssue);
            // </SnippetPredictIssue>

            // <SnippetDisplayResults>
            Console.WriteLine($"=============== Single Prediction - Result: {prediction.Type} ===============");
            // </SnippetDisplayResults>
        }

        private static void SaveModelAsFile(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
        {
            // <SnippetSaveModel>
            mlContext.Model.Save(model, trainingDataViewSchema, _modelPath);
            // </SnippetSaveModel>

            Console.WriteLine("The model is saved to {0}", _modelPath);
        }
    }

    internal class Output
    {
        [ColumnName("PredictedLabel")]
        public string Type { get; set; }
    }

    internal class Input
    {
        [LoadColumn(7)]
        public float M { get; set; }

        [LoadColumn(8)]
        public float R { get; set; }

        [LoadColumn(9)]
        public float F { get; set; }

        [LoadColumn(11)]
        public string Type { get; set; }
    }
}