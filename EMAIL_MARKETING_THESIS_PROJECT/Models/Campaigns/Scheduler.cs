using System;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Scheduler
    {
        public long Id { get; set; }

        public bool IsSendNow { get; set; }

        public DateTime SendOn { get; set; }

        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
