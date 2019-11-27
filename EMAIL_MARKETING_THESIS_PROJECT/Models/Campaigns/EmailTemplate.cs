namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class EmailTemplate
    {
        public int Id { get; set; }

        public string Sender { get; set; }

        public string Receiver { get; set; }

        public string Subject { get; set; }

        public Template Template { get; set; }

        public Campaign Campaign { get; set; }
    }
}
