using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
    public interface IFiltering
    {
        List<RFMSubscriber> Filter(List<RFMSubscriber> list, CriteriaViewModel criteria);
    }
}