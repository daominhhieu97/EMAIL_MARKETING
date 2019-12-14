using Microsoft.ML.Data;

namespace RFMModel
{
    public class InputRFMCustomer
    {
        [LoadColumnAttribute(5)]
        public float Frequency { get; set; }

        [LoadColumnAttribute(6)]
        public float Recency { get; set; }

        [LoadColumnAttribute(7)]
        public float Monetary { get; set; }

        [LoadColumnAttribute(11)]
        public string RFMClass { get; set; }
    }
}