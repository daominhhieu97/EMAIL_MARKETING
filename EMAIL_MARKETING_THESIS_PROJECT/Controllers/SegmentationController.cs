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
using NToastNotify;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class SegmentationController : Controller
    {
        private readonly ProjectContext context;
        private readonly Filtering filtering;
        private readonly IKmeanCustomerAnalyzer<RFMSubscriber> kmeanCustomerAnalyzer;
        private readonly IToastNotification toastNotification;

        public SegmentationController(
            ProjectContext context,
            Filtering filtering,
            IKmeanCustomerAnalyzer<RFMSubscriber> kmeanCustomerAnalyzer, IToastNotification toastNotification)
        {
            this.context = context;
            this.filtering = filtering;
            this.kmeanCustomerAnalyzer = kmeanCustomerAnalyzer;
            this.toastNotification = toastNotification;
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
                toastNotification.AddInfoToastMessage("There aren't any subscriber in this mailing list.");

                return RedirectToAction("GetMailingLists", "MailingList");
            }

            await SegmentSubscriber(viewModel.AddSegmentationViewModel, subscribers);

            toastNotification.AddSuccessToastMessage($"Segmented {viewModel.AddSegmentationViewModel.NewName} successfully.");

            return RedirectToAction("GetMailingLists", "MailingList");
        }

        private async Task SegmentSubscriber(AddSegmentationViewModel viewModel, List<RFMSubscriber> matchedSubscribers)
        {
            var segmentedMailingList = new MailingList(viewModel.NewName);

            List<RFMSubscriber> subscribers;

            if (viewModel.UseRFMFiltering)
            {
                subscribers = matchedSubscribers.Any(s => (s.Frequency != null || s.Monetary != null || s.Recency != null || s.RFMClass != null))
                    ? kmeanCustomerAnalyzer.Filter(matchedSubscribers, viewModel.CriteriaViewModel, viewModel.SubscriberRateClass)
                    : new List<RFMSubscriber>();
            }
            else
            {
                subscribers = filtering.Filter(matchedSubscribers, viewModel.CriteriaViewModel);
            }

            await CreateNewMailingListWithSubscriber(segmentedMailingList, subscribers);
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