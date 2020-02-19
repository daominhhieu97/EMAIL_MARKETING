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
      var result = new List<RFMSubscriber>();

      foreach (var rfmSubscriber in list)
      {
        if (SubscriberIsGood(rfmSubscriber, criteria))
          result.Add(rfmSubscriber);
      }

      return result;
    }

    private bool SubscriberIsGood(RFMSubscriber rfmSubscriber, CriteriaViewModel criteria)
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