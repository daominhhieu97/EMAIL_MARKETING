using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Contracts.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
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
            return View();
        }

        public IActionResult Create()
        {
            var viewModel = new Campaign();

            return View(viewModel);
        }

        public IActionResult Create(Campaign viewModel)
        {
            var campaign = new Campaign
            {
                Title = viewModel.Title,
                EmailInfo = viewModel.EmailInfo,
                MailingList = viewModel.MailingList,
                Scheduler = viewModel.Scheduler
            };

            context.Set<Campaign>().Add(campaign);

            context.SaveChanges();

            return RedirectToAction("Details", "Campaign", new { @id = viewModel.Id });
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

            return RedirectToAction("Details", "Campaign", new { @id = campaign.Id});
        }

        public IActionResult Details (int id)
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