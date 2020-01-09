using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer<RFMSubscriber>
    {
        public List<RFMSubscriber> Filter(
            List<RFMSubscriber> subscribers,
            CriteriaViewModel criteria,
            string subscriberRateClass)
        {
            var rfmSubscribers = new List<RFMSubscriber>();

            subscribers.ForEach(x =>
            {
                if (x.RFMClass == subscriberRateClass && IsGoodSubscriber(x, criteria))
                {
                    rfmSubscribers.Add(x);
                }
            });

            return rfmSubscribers;
        }

        private bool IsGoodSubscriber(RFMSubscriber rfmSubscriber, CriteriaViewModel criteria)
        {
            bool flag = false;

            if (!string.IsNullOrEmpty(criteria.Name) && rfmSubscriber.Name.Contains(criteria.Name))
            {
                flag = true;
            }

            if (rfmSubscriber.Age == criteria.Age)
            {
                flag = true;
            }

            if (!string.IsNullOrEmpty(criteria.City) && rfmSubscriber.City.Contains(criteria.City))
            {
                flag = true;
            }

            if (!string.IsNullOrEmpty(criteria.Area) && rfmSubscriber.Area.Contains(criteria.Area))
            {
                flag = true;
            }

            if (!string.IsNullOrEmpty(criteria.Email) && rfmSubscriber.Email.Contains(criteria.Email))
            {
                flag = true;
            }

            return flag;
        }
    }
}