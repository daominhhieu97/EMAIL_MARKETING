namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Email
    {
        public string Sender { get; set; }

        public string Receiver { get; set; }

        public string Subject { get; set; }

        public Template Template { get; set; }
    }
}
