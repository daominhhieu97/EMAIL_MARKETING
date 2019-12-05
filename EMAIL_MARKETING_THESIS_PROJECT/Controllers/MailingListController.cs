using System;
using System.Collections.Generic;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;
using IronPython.Runtime.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class MailingListController : Controller
    {
        private readonly ProjectContext context;
        private readonly SubscriberParser parser;

        public MailingListController(ProjectContext projectContext, SubscriberParser parser)
        {
            this.context = projectContext;
            this.parser = parser;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMailingLists()
        {
            var viewModel = context.Set<MailingList>()
                .Include(m => m.SubscribersLink)
                .ToList();

            return View(viewModel);
        }

        public IActionResult Create()
        {
            var mailingList = new MailingList();

            return View(mailingList);
        }

        [HttpPost]
        public IActionResult Create(MailingList createMailingList)
        {
            var mailingList = new MailingList(createMailingList.Title);

            context.Set<MailingList>().Add(mailingList);
            context.SaveChanges();

            return RedirectToAction("Details", "MailingList", new { id = mailingList.Id });
        }

        public IActionResult Details(int id)
        {
            var mailingList = context.Set<MailingList>()
                .Include(m => m.SubscribersLink)
                .Single(m => m.Id == id);

            var subscribers = GetSubscribers(mailingList);

            var viewModel = new MailingListDetailsViewModel()
            {
                MailingList = mailingList,
                Subscribers = subscribers,
                AddSegmentationViewModel = new AddSegmentationViewModel { MailingListId = mailingList.Id },
                AddContactsViewModel = new AddContactsViewModel { MailingListId = mailingList.Id }
            };

            return View(viewModel);
        }

        private List<Subscriber> GetSubscribers(MailingList mailingList)
        {
            List<Subscriber> subscribers = context.Set<MailingListSubscriber>()
                .Where(ms => ms.MailingListId == mailingList.Id)
                .Select(ms => ms.Subscriber)
                .ToList();

            return subscribers;
        }

        public IActionResult Delete(int id)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == id);

            context.Set<MailingList>().Remove(mailingList);

            context.SaveChanges();

            return RedirectToAction("GetMailingLists", "MailingList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == id);

            return View(mailingList);
        }

        [HttpPost]
        public IActionResult Edit(MailingList viewModel)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == viewModel.Id);

            mailingList.Update(viewModel.Title);

            context.SaveChanges();

            return RedirectToAction("Details", "MailingList", new { id = mailingList.Id });
        }

        [HttpPost]
        public IActionResult AddContacts(int mailingListId, Subscriber[] subscribers)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == mailingListId);

            foreach (var subscriber in subscribers)
            {
                var mailingListToSubscriber = new MailingListSubscriber
                {
                    MailingList = mailingList,
                    Subscriber = subscriber
                };

                mailingList.SubscribersLink.Add(mailingListToSubscriber);

                context.SaveChanges();
            }

            return RedirectToAction("Details", "MailingList", new { id = mailingListId });
        }

        [HttpPost]
        public IActionResult AddContact(MailingListDetailsViewModel viewModel)
        {
            var mailingList = context.Set<MailingList>().Include(m => m.SubscribersLink).Single(m => m.Id == viewModel.AddContactsViewModel.MailingListId);

            var subscribers = parser.Parse(viewModel.AddContactsViewModel.Subscribers);

            foreach (var rfmSubscriber in subscribers)
            {
                var mlSub = new MailingListSubscriber
                {
                    MailingList = mailingList,
                    Subscriber = rfmSubscriber
                };

                mailingList.SubscribersLink.Add(mlSub);
            }

            context.SaveChanges();

            return RedirectToAction("Details", new { id = mailingList.Id });
        }
    }
}