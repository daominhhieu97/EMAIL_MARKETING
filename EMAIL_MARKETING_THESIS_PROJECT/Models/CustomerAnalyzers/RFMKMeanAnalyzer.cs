using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Sub = EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer<Sub.RFMSubscriber>
    {
        public Cluster<Sub.RFMSubscriber>[] Analyze(MailingList<Sub.RFMSubscriber> mailingList)
        {
            
        }
    }
}
