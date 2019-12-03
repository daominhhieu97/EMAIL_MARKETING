using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Campaigns;
using Microsoft.AspNetCore.Mvc;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ProjectContext context;

        public CampaignController(ProjectContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var viewModel = context.Set<Campaign>().ToList();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateCampaignViewModel();

            viewModel.MailingLists = context.Set<MailingList>().ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateCampaignViewModel viewModel)
        {
            var campaign = new Campaign
            {
                Title = viewModel.Campaign.Title,
                EmailInfo = viewModel.Campaign.EmailInfo,
                MailingList = context.Set<MailingList>().Single(ml => ml.Id == viewModel.SelectedMailingListId),
                Scheduler = viewModel.Campaign.Scheduler
            };

            context.Set<Campaign>().Add(campaign);

            context.SaveChanges();

            return RedirectToAction("Index", "Campaign");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == id);

            return View(campaign);
        }

        public IActionResult Edit(Campaign viewModel)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == viewModel.Id);

            campaign.Update(viewModel);

            return RedirectToAction("Details", "Campaign", new { @id = campaign.Id });
        }

        public IActionResult Details(int id)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == id);

            return View(campaign);
        }

        public void Delete(int id)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == id);

            context.Set<Campaign>().Remove(campaign);

            context.SaveChanges();
        }
    }
}