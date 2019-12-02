using EMAIL_MARKETING_THESIS_PROJECT.Controllers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.ViewModels
{
    public  class MailingListDetailsViewModel
    {
        public MailingListDetailsViewModel()
        {
        }

        public MailingList MailingList { get; internal set; }

        public List<Subscriber> Subscribers { get; internal set; }

        public string CategoryType { get; set; }
    }
}