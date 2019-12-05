using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class SubscriberParser
    {
        public List<RFMSubscriber> Parse(string subscribers)
        {
            var rfmSubscribers = new List<RFMSubscriber>();

            var subscribersInfo = subscribers.Split("\r");

            foreach (var subscriberInfo in subscribersInfo)
            {
                var info = subscriberInfo.Split(",");

                var subscriber = new RFMSubscriber()
                {
                    Name = info[0],
                    Email = info[1],
                    Phone = info[2]
                };

                rfmSubscribers.Add(subscriber);
            }

            return rfmSubscribers;
        }
    }
}