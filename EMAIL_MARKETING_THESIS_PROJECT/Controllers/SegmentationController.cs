using System;
using System.Collections.Generic;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class SegmentationController : Controller
    {
        private readonly ProjectContext context;
        private readonly DemographicFiltering demographicFiltering;
        private readonly GeographicFiltering geographicFiltering;
        private readonly IKmeanCustomerAnalyzer kmeanCustomerAnalyzer;

        public SegmentationController(
            ProjectContext context, 
            DemographicFiltering demographicFiltering, 
            GeographicFiltering geographicFiltering,
            IKmeanCustomerAnalyzer kmeanCustomerAnalyzer)
        {
            this.context = context;
            this.demographicFiltering = demographicFiltering;
            this.geographicFiltering = geographicFiltering;
            this.kmeanCustomerAnalyzer = kmeanCustomerAnalyzer;
        }

        public IActionResult AddSegment(
            int mailingListId, 
            string name, 
            string  subscriberRateClass,
            string categoryType, 
            Criteria[] criterias)
        {
            var mailingList = context.Set<MailingList>()
                .Include(m => m.SubscribersLink)
                .Single(m => m.Id == mailingListId);

            var segmentedMailingList = SegmentSubscriber(mailingList, name,  categoryType, subscriberRateClass, criterias);
            
            return RedirectToAction("Details", "MailingList", segmentedMailingList.Id);
        }

        private MailingList SegmentSubscriber(
            MailingList mailingList, 
            string name, 
            string categoryType, 
            string subscriberRateClass, 
            Criteria[] criterias)
        {
            var segmentedMailingList = new MailingList(name);
            var subscribers = new List<RFMSubscriber>();

            switch (categoryType)
            {
                case CategoryTypes.DEMOGRAPHIC:
                    subscribers = demographicFiltering.Filter(mailingList, criterias);
                    break;
                case CategoryTypes.GEOGRAPHIC:
                    subscribers = geographicFiltering.Filter(mailingList, criterias);
                    break;
                case CategoryTypes.KMEANS:
                    subscribers = kmeanCustomerAnalyzer.Analyze(mailingList, subscriberRateClass);
                    break;
            }

            CreateNewMailingListWithSubscriber(segmentedMailingList, subscribers);

            return segmentedMailingList;
        }

        private void CreateNewMailingListWithSubscriber(MailingList segmentedMailingList, List<RFMSubscriber> subscribers)
        {
            throw new NotImplementedException();
        }
    }
}