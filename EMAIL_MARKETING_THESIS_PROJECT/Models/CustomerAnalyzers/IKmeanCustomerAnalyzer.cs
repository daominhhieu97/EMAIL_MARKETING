using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.ML;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public interface IKmeanCustomerAnalyzer
    {
        List<RFMSubscriber> Analyze(List<RFMSubscriber> subscribers, string categoryClass);
    }
}