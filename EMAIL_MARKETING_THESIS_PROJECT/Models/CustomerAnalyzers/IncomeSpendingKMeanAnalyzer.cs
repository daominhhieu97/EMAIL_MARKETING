using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sub = EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Linq;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class IncomeSpendingKMeanAnalyzer : IKmeanCustomerAnalyzer<Sub.IncomeSpendingSubscriber>
    {
        public Cluster<Sub.IncomeSpendingSubscriber>[] Analyze(MailingList<Sub.IncomeSpendingSubscriber> mailingList)
        {
            throw new NotImplementedException();
        }
    }
}
