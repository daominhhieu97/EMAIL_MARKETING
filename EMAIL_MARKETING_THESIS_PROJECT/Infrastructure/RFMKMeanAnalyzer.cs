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

            foreach (var rfmSubscriber in subscribers)
            {
                if (rfmSubscriber.RFMClass.Trim().Equals(subscriberRateClass))
                    if (IsGoodSubscriber(rfmSubscriber, criteria))
                        rfmSubscribers.Add(rfmSubscriber);
            }

            return rfmSubscribers;
        }

        private bool IsGoodSubscriber(RFMSubscriber rfmSubscriber, CriteriaViewModel criteria)
        {
            var flagName = !string.IsNullOrEmpty(criteria.Name) && rfmSubscriber.Name.Contains(criteria.Name);

            var flagAge = criteria.Age == 0 || rfmSubscriber.Age == criteria.Age;

            var flagCity = !string.IsNullOrEmpty(criteria.City) && rfmSubscriber.City.Contains(criteria.City);

            var flagArea = !string.IsNullOrEmpty(criteria.Area) && rfmSubscriber.Area.Contains(criteria.Area);

            var flagEmail = !string.IsNullOrEmpty(criteria.Email) && rfmSubscriber.Email.Contains(criteria.Email);

            return flagEmail || flagAge || flagArea || flagCity || flagName;
        }
    }
}