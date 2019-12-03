using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists
{
    public class AddSegmentationViewModel
    {
        public int MailingListId { get; set; }

        public string NewName { get; set; }

        public string CategoryType { get; set; }

        public string SubscriberRateClass { get; set; }

        public Criteria[] Criterias { get; set; }
    }
}