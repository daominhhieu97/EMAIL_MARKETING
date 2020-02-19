using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns
{
    public class Segment
    {
        public Segment()
        {
            this.Subscribers = new List<RFMSubscriber>();
        }

        public Segment(string viewModelNewName)
        {
            this.Name = viewModelNewName;
            this.Subscribers = new List<RFMSubscriber>();
        }

        public int Id { get; set; }

        public MailingList MailingList { get; set; }

        public string Name { get; set; }

        public virtual ICollection<RFMSubscriber> Subscribers { get; set; }
    }
}