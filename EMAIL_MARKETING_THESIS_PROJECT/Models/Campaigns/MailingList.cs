using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class MailingList <T>
    {
        public int ListId { get; set; }

        public string Title { get; set; }

        public List<T> Subscribers { get; set; }
    }
}
