namespace EMAIL_MARKETING_THESIS_PROJECT.Models
{
    interface ICustomerAnalyzer
    {
        public Cluster[] RFMAnalyze(MailingList mailingList);
    }
}
