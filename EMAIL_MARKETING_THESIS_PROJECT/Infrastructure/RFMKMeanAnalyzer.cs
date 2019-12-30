using System;
using System.Collections.Generic;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace EMAIL_MARKETING_THESIS_PROJECT.Infrastructure
{
    public class RFMKMeanAnalyzer : IKmeanCustomerAnalyzer<RFMSubscriber>
    {
        public List<RFMSubscriber> Analyze(
            List<RFMSubscriber> subscribers,
            CriteriaViewModel criteria,
            string subscriberRateClass)
        {
            var rfmSubscribers = new List<RFMSubscriber>();

            subscribers.ForEach(x =>
            {
                if (x.RFMClass == subscriberRateClass && Filter(x, criteria))
                {
                    rfmSubscribers.Add(x);
                }
            });

            return rfmSubscribers;
        }

        private bool Filter(RFMSubscriber rfmSubscriber, CriteriaViewModel criteria)
        {
            try
            {
                criteria.Name = string.IsNullOrEmpty(criteria.Name) ? string.Empty : criteria.Name;
                criteria.Area = string.IsNullOrEmpty(criteria.Name) ? string.Empty : criteria.Area;
                criteria.City = string.IsNullOrEmpty(criteria.Name) ? string.Empty : criteria.City;
                criteria.Email = string.IsNullOrEmpty(criteria.Name) ? string.Empty : criteria.Email;

                return rfmSubscriber.Name.Contains(criteria.Name)
                       || rfmSubscriber.Age == criteria.Age
                       || rfmSubscriber.Area.Contains(criteria.Area)
                       || rfmSubscriber.City.Contains(criteria.City)
                       || rfmSubscriber.Email.Contains(criteria.Email);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}