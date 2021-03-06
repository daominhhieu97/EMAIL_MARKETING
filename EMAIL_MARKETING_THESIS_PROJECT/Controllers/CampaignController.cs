﻿using System;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Infrastructure;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Campaigns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class CampaignController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ProjectContext context;
        private readonly EmailSender emailSender;

        public CampaignController(ProjectContext context, EmailSender emailSender, IToastNotification toastNotification)
        {
            this.emailSender = emailSender;
            this.toastNotification = toastNotification;
            this.context = context;
        }

        public IActionResult Index()
        {
            var viewModel = context.Set<Campaign>()
                .Include(c => c.EmailInfo)
                .Include(c => c.MailingList)
                .Include(c => c.Scheduler)
                .ToList();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateCampaignViewModel
            {
                MailingLists = context.Set<MailingList>().Include(m => m.Segments).ToList(),
                Templates = context.Set<Template>().ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCampaignViewModel viewModel)
        {
            var campaign = new Campaign
            {
                Title = viewModel.Campaign.Title,
                EmailInfo = viewModel.Campaign.EmailInfo,
                SegmentId = viewModel.SelectedMailingListId,
                Scheduler = viewModel.Campaign.Scheduler
            };

            var template = context.Set<Template>().Single(t => t.Id == viewModel.SelectedTemplateId);

            var segment = context.Set<Segment>().Include(s => s.MailingList)
                .Single(s => s.Id == viewModel.SelectedMailingListId);
            campaign.MailingList = segment.MailingList;
            campaign.EmailInfo.Template = template;

            if (campaign.Scheduler.IsSendNow) campaign.Scheduler.SendOn = DateTime.Now;

            context.Set<Campaign>().Add(campaign);

            context.SaveChanges();

            if (campaign.Scheduler.IsSendNow)
            {
                await emailSender.SendEmail(campaign);
            }

            toastNotification.AddSuccessToastMessage($"Create the new campaign {campaign.Title} successfully.");

            return RedirectToAction("Details", new { campaign.Id });
        }

        public IActionResult Edit(Campaign viewModel)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == viewModel.Id);

            campaign.Update(viewModel);

            context.SaveChanges();

            toastNotification.AddSuccessToastMessage($"Update {campaign.Title} successfully.");

            return RedirectToAction("Details", "Campaign", new { id = campaign.Id });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var campaign = context.Set<Campaign>()
                .Include(c => c.MailingList)
                .Include(c => c.EmailInfo)
                .Include(c => c.Scheduler)
                .Single(c => c.Id == id);

            return View(campaign);
        }

        public IActionResult Delete(int id)
        {
            var campaign = context.Set<Campaign>().Single(c => c.Id == id);

            context.Set<Campaign>().Remove(campaign);

            try
            {
                context.SaveChanges();

                toastNotification.AddSuccessToastMessage($"Delete {campaign.Title} successfully.");
            }
            catch
            {
                toastNotification.AddSuccessToastMessage($"Delete {campaign.Title} failed.");
            }

            return RedirectToAction("Index", "Campaign");
        }

        public async Task<IActionResult> SendEmailAsync(int id)
        {
            var campaign = context.Set<Campaign>()
                .Include(c => c.EmailInfo)
                .Include(c => c.MailingList)
                .Include(c => c.Scheduler)
                .Single(c => c.Id == id);

            await emailSender.SendEmail(campaign);

            return RedirectToAction("Details", new { id = campaign.Id });
        }

        public async Task<IActionResult> Resent(int id)
        {
            var campaign = context.Set<Campaign>()
                .Include(c => c.EmailInfo).ThenInclude(et => et.Template)
                .Include(c => c.MailingList)
                .Include(c => c.Scheduler)
                .Single(c => c.Id == id);

            await emailSender.SendEmail(campaign);

            toastNotification.AddSuccessToastMessage("Resend the emails successfully.");

            return RedirectToAction("Details", new { id = campaign.Id });
        }
    }
}