using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers
{
    public class MailingListSubscriber
    {
        public int MailingListId { get; set; }
        public MailingList MailingList { get; set; }

        public int SubscriberId { get; set; }
        public RFMSubscriber Subscriber { get; set; }
    }
}