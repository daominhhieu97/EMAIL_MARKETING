namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class EmailTemplate
    {
        public EmailTemplate()
        {
            this.Template = new Template();
        }

        public int Id { get; set; }

        public string Subject { get; set; }

        public string Name { get; set; }

        public string Sender { get; set; }

        public Template Template { get; set; }

        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}