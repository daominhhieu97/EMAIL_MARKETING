using System.Collections.Generic;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class SubscriberParser
    {
        public List<RFMSubscriber> Parse(string subscribers)
        {
            var subscribersInfo = subscribers.Split("\r");

            return subscribersInfo.Select(subscriberInfo => subscriberInfo.Split(","))
                .Select(info => new RFMSubscriber()
                {
                    Name = info[0].Trim(),
                    Email = info[1].Trim(),
                    Phone = info[2].Trim(),
                    Frequency = float.Parse(info[3].Trim()),
                    Recency = float.Parse(info[4].Trim()),
                    Monetary = float.Parse(info[5].Trim())
                })
                .ToList();
        }
    }
}