namespace RFM_Console.Models
{
    interface ICustomerAnalyzer
    {
        public Cluster[] RFMAnalyze(MailingList mailingList);
    }
}
