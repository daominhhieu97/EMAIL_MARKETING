using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists
{
    public class AddSegmentationViewModel
    {
        public int MailingListId { get; set; }

        public string NewName { get; set; }

        public bool UseKmeans { get; set; }

        public string SubscriberRateClass { get; set; }

        public CriteriaViewModel CriteriaViewModel { get; set; }

        public SelectListItem[] Cities { get; set;  }

        public SelectListItem[] Areas { get; set; }

    }

    public class CriteriaViewModel
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public string Area { get; set; }
    }
}