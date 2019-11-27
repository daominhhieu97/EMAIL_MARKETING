namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Campaign
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public EmailTemplate Email { get; set; }

        public MailingList MailingList { get; set; }

        public Scheduler Scheduler { get; set; }
    }
}
