using System;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult AddSegment(int mailingListId, string name, string categoryType, Criteria[] criterias)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == mailingListId);

            var segmentedMailingList = SegmentSubscriber(mailingList, name,  categoryType, criterias);
            
            return View(segmentedMailingList);
        }

        private MailingList SegmentSubscriber(MailingList mailingList, string name, string categoryType, Criteria[] criterias)
        {
            var segmentedMailingList = new MailingList(name);

            switch (categoryType)
            {
                case CategoryTypes.DEMOGRAPHIC:
                    segmentedMailingList = demographicFiltering.Filter(mailingList, criterias);
                    break;
                case CategoryTypes.GEOGRAPHIC:
                    segmentedMailingList = geographicFiltering.Filter(mailingList, criterias);
                    break;
                case CategoryTypes.KMEANS:
                    segmentedMailingList = kmeanCustomerAnalyzer.Analyze(mailingList, RFMCategoryClass.Champion);
                    break;
            }

            return segmentedMailingList;
        }
    }
}