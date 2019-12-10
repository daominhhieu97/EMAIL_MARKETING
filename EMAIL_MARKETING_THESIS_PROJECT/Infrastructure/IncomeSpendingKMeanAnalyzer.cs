using System;
using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class IncomeSpendingKMeanAnalyzer : IKmeanCustomerAnalyzer
    {
        public List<RFMSubscriber> Analyze(MailingList mailingList, string categoryClass)
        {
            throw new NotImplementedException();
        }
    }
}