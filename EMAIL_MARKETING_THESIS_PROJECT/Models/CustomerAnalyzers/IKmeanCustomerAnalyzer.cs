using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    interface IKmeanCustomerAnalyzer <T>
    {
        public Cluster<T>[] Analyze(MailingList <T> mailingList);
    }
}
