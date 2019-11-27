using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    interface IKmeanCustomerAnalyzer
    {
        public Cluster[] Analyze(MailingList mailingList, string categoryClass);
    }
}
