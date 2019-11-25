using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class RFMKMeanAnalyzer<T> : IKmeanCustomerAnalyzer<T>
    {

        public Cluster<T>[] Analyze(MailingList<T> mailingList)
        {

        }
    }
}
