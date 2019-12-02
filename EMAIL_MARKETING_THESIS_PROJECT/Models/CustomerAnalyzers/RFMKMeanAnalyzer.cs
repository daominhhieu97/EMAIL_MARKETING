using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Sub = EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer
    {
        public List<RFMSubscriber> Analyze(MailingList mailingList, string subscriberRateClass)
        {
            var path = @"dafadf";
            var file = GetRFMFile(path, subscriberRateClass);
            var subscribers = GetSubscribers(file);

            return subscribers;
        }

        private List<RFMSubscriber> GetSubscribers(object file)
        {
            throw new NotImplementedException();
        }

        private object GetRFMFile(string path, string subscriberRateClass)
        {
            throw new NotImplementedException();
        }
    }
}
