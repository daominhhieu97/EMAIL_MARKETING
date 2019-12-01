using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public interface IKmeanCustomerAnalyzer
    {
        public MailingList Analyze(MailingList mailingList, string categoryClass);
    }
}
