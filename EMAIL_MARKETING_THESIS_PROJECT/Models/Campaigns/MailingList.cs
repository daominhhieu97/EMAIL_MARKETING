using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using System;
using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class MailingList
    {
        public MailingList()
        {

        }

        public MailingList(string name)
        {
            this.Title = name;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual List<MailingListSubscriber> SubscribersLink  { get; set; }

        internal void Update(MailingList updatedMailingList)
        {
            this.Title = updatedMailingList.Title;
        }
    }
}
