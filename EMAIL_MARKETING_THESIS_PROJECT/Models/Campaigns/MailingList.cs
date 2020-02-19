using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class MailingList
    {
        public MailingList()
        {
            this.SubscribersLink = new List<MailingListSubscriber>();
            this.Segments = new List<Segment>();
        }

        public MailingList(string name)
        {
            this.Title = name;
            this.SubscribersLink = new List<MailingListSubscriber>();
            this.Segments = new List<Segment>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual List<MailingListSubscriber> SubscribersLink { get; set; }

        public virtual ICollection<Segment> Segments { get; set; }

        internal void Update(string title)
        {
            this.Title = title;
        }
    }
}