using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;
using Microsoft.ML;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public interface IKmeanCustomerAnalyzer<T>
    {
        List<T> Analyze(List<T> subscribers, CriteriaViewModel criteria, string subscriberRateClass);
    }
}