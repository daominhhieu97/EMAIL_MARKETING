using System.Collections.Generic;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMSubscriberParser : SubscriberParser
    {
        #region Overrides of SubscriberParser

        public override List<RFMSubscriber> Parse(string subscribers)
        {
            var subscribersInfo = subscribers.Split("\r");

            return subscribersInfo.Select(subscriberInfo => subscriberInfo.Split(","))
                .Select(info => new RFMSubscriber()
                {
                    Name = info[0].Trim(),
                    Email = info[1].Trim(),
                    Phone = info[2].Trim(),
                    Monetary = string.IsNullOrEmpty(info[3].Trim()) ? 0 : float.Parse(info[3].Trim()),
                    Recency = string.IsNullOrEmpty(info[4].Trim()) ? 0 : float.Parse(info[4].Trim()),
                    Frequency = string.IsNullOrEmpty(info[5].Trim()) ? 0 : float.Parse(info[5].Trim()),
                    RFMClass = info[6].Trim()
                })
                .ToList();
        }

        #endregion Overrides of SubscriberParser
    }
}