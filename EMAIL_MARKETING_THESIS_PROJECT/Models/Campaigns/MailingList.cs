using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class MailingList
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Subscribers.RFMSubscriber> Subscribers  { get; set; }
    }
}
