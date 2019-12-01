using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers
{
    public class MailingListSubscriber
    {
        public int MailingListId { get; set; }
        public MailingList MailingList { get; set; }

        public int SubscriberId { get; set; }
        public Subscriber Subscriber { get; set; }
    }
}
