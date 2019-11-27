using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sub = EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Linq;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class IncomeSpendingKMeanAnalyzer : IKmeanCustomerAnalyzer
    {

        Cluster[] IKmeanCustomerAnalyzer.Analyze(MailingList mailingList, string categoryClass)
        {
            throw new NotImplementedException();
        }
    }
}
