using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public abstract class SubscriberParser
    {
        public abstract List<RFMSubscriber> Parse(string subscribers);
    }
}