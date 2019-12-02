using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public interface IKmeanCustomerAnalyzer
    {
        public List<RFMSubscriber> Analyze(MailingList mailingList, string categoryClass);
    }
}
