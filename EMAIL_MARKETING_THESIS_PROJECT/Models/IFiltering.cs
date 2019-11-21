using System.Collections.Generic;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models
{
    public interface IFiltering
    {
        public List<Subscriber> Filter(MailingList list);
    }
}
