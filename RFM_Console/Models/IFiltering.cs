using System.Collections.Generic;

namespace RFM_Console.Models
{
    public interface IFiltering
    {
        public List<Subscriber> Filter(MailingList list);
    }
}
