﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Campaign
    {
        public Campaign()
        {
            EmailInfo = new EmailTemplate();
            MailingList = new MailingList();
            Scheduler = new Scheduler();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual EmailTemplate EmailInfo { get; set; }

        public virtual MailingList MailingList { get; set; }

        public int? SegmentId { get; set; }

        public virtual Scheduler Scheduler { get; set; }

        public void Update(Campaign updatedCampaign)
        {
            this.Title = updatedCampaign.Title;
        }
    }
}