using System;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Campaign
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public virtual EmailTemplate EmailInfo { get; set; }

        public virtual MailingList MailingList { get; set; }

        public virtual Scheduler Scheduler { get; set; }

        public void Update(Campaign updatedCampaign)
        {
            throw new NotImplementedException();
        }
    }
}
