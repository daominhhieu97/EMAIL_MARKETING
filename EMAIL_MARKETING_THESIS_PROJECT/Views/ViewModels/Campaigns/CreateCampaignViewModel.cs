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

        public int SelectedTemplateId { get; set; }

        public SelectListItem[] GetMailingListItems()
        {
            return MailingLists.Select(m => new SelectListItem { Text = m.Title, Value = m.Id.ToString() }).ToArray();
        }

        public List<Template> Templates { get; set; }

        public IEnumerable<SelectListItem> GetTemplateItems()
        {
            return Templates.Select(m => new SelectListItem { Text = m.Name, Value = m.Id.ToString() }).ToArray();
        }
    }
}