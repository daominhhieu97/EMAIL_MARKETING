using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers
{
  public class Filtering : IFiltering
  {
    public List<RFMSubscriber> Filter(List<RFMSubscriber> list, CriteriaViewModel criteria)
    {
      return list.Where(subscriber => SubscriberIsGood(subscriber, criteria)).ToList();
    }

    private bool SubscriberIsGood(RFMSubscriber rfmSubscriber, CriteriaViewModel criteria)
    {
      try
      {
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