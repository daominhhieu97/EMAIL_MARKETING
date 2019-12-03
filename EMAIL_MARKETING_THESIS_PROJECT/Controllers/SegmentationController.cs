using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
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
            var mailingList = context.Set<MailingList>()
                .Include(m => m.SubscribersLink)
                .Single(m => m.Id == viewModel.AddSegmentationViewModel.MailingListId);

            var segmentedMailingList = await SegmentSubscriber(viewModel.AddSegmentationViewModel, mailingList);

            return RedirectToAction("GetMailingLists", "MailingList");
        }

        private async Task<MailingList> SegmentSubscriber(AddSegmentationViewModel viewModel, MailingList mailingList)
        {
            var segmentedMailingList = new MailingList(viewModel.NewName);
            var subscribers = new List<RFMSubscriber>();

            switch (viewModel.CategoryType)
            {
                case CategoryTypes.DEMOGRAPHIC:
                    subscribers = demographicFiltering.Filter(mailingList, viewModel.Criterias);
                    break;

                case CategoryTypes.GEOGRAPHIC:
                    subscribers = geographicFiltering.Filter(mailingList, viewModel.Criterias);
                    break;

                case CategoryTypes.KMEANS:
                    subscribers = kmeanCustomerAnalyzer.Analyze(mailingList, viewModel.SubscriberRateClass);
                    break;
            }

            await CreateNewMailingListWithSubscriber(segmentedMailingList, subscribers);

            return segmentedMailingList;
        }

        private async Task CreateNewMailingListWithSubscriber(MailingList segmentedMailingList, List<RFMSubscriber> subscribers)
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