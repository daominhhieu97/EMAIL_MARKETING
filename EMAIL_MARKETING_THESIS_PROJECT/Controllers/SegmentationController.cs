using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Common;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;
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

        [HttpPost]
        public async Task<IActionResult> AddSegment(MailingListDetailsViewModel viewModel)
        {
            var subscribers = context
                .Set<MailingListSubscriber>()
                .Where(mls => mls.MailingListId == viewModel.AddSegmentationViewModel.MailingListId)
                .Select(mls => mls.Subscriber).ToList();

            if (subscribers.Count == 0)
            {
                return BadRequest(new { errorMessage = "There aren't any subscriber in this mailing list." });
            }

            var segmentedMailingList = await SegmentSubscriber(viewModel.AddSegmentationViewModel, subscribers);

            return RedirectToAction("GetMailingLists", "MailingList");
        }

        private async Task<MailingList> SegmentSubscriber(AddSegmentationViewModel viewModel, List<RFMSubscriber> matchedSubscribers)
        {
            var segmentedMailingList = new MailingList(viewModel.NewName);

            List<RFMSubscriber> subscribers;
            switch (viewModel.SegmentationType)
            {
                case SegmentationTypes.DEMOGRAPHIC:
                    subscribers = demographicFiltering.Filter(matchedSubscribers, viewModel.Criteria);
                    break;

                case SegmentationTypes.GEOGRAPHIC:
                    subscribers = geographicFiltering.Filter(matchedSubscribers, viewModel.Criteria);
                    break;

                case SegmentationTypes.KMEANS:
                    if (matchedSubscribers.Any(s => (s.Frequency == null || s.Monetary == null || s.Recency == null)))
                        subscribers = new List<RFMSubscriber>();

                    subscribers = kmeanCustomerAnalyzer.Analyze(matchedSubscribers, viewModel.SubscriberRateClass);
                    break;

                default:
                    subscribers = new List<RFMSubscriber>();
                    break;
            }

            await CreateNewMailingListWithSubscriber(segmentedMailingList, subscribers);

            return segmentedMailingList;
        }

        private async Task CreateNewMailingListWithSubscriber(MailingList segmentedMailingList, IEnumerable<RFMSubscriber> subscribers)
        {
            foreach (var subscriber in subscribers)
            {
                segmentedMailingList.SubscribersLink.Add(new MailingListSubscriber { MailingList = segmentedMailingList, Subscriber = subscriber });
            }

            context.Set<MailingList>().Add(segmentedMailingList);

            await context.SaveChangesAsync();
        }
    }
}