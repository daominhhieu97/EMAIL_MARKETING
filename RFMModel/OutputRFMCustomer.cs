using Microsoft.ML.Data;

namespace RFMModel
{
    public class OutputRFMCustomer
    {
        [ColumnName("PredictedLabel")]
        public string RFMClass { get; set; }
    }
}