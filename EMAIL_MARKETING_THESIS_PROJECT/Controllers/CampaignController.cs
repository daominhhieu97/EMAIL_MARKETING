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
            var viewModel = CreatCampaignViewModel();

            return View(viewModel);
        }

        private object CreatCampaignViewModel()
        {
            throw new NotImplementedException();
        }

        public IActionResult Create(CreateCampaignRequest request)
        {
            var campaign = new Campaign
            {
                Title = request.Title,
                EmailInfo = CreateEmailInfo(request),
                MailingList = CreateMailingList(request),
                Scheduler = CreateScheduler(request)
            };

            context.Set<Campaign>().Add(campaign);

            context.SaveChanges();

            return RedirectToAction("Details", "Campaign", new { @id = request.CampaignId });
        }

        private Scheduler CreateScheduler(CreateCampaignRequest request)
        {
            throw new NotImplementedException();
        }

        private MailingList CreateMailingList(CreateCampaignRequest request)
        {
            throw new NotImplementedException();
        }

        private EmailTemplate CreateEmailInfo(CreateCampaignRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Edit(int campaignId)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == campaignId);

            return View(campaign);
        }

        public IActionResult Edit(EditCampaignRequest request)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == request.CampaignId);

            campaign.Update(request.EditParts);

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