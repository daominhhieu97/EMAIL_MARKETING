using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers
{
    public class Subscriber
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public string City { get; set; }

        public string Area { get; set; }

        public virtual List<MailingListSubscriber> MailingListsLink { get; set; }
    }
}