using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Campaigns
{
    public class CreateCampaignViewModel
    {
        public CreateCampaignViewModel()
        {
            Campaign = new Campaign();
        }

        public Campaign Campaign { get; internal set; }

        public int SelectedMailingListId { get; set; }

        public List<MailingList> MailingLists { get; set; }

        public SelectListItem[] GetMailingListItems()
        {
            return MailingLists.Select(m => new SelectListItem { Text = m.Title, Value = m.Id.ToString() }).ToArray();
        }
    }
}