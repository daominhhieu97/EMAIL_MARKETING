using System;
using System.Collections.Generic;
using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class MailingListController : Controller
    {
        private readonly ProjectContext context;

        public MailingListController(ProjectContext projectContext)
        {
            this.context = projectContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMailingLists()
        {
            var viewModel = context.Set<MailingList>().ToList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(string name)
        {
            MailingList mailingList = new MailingList(name);

            context.Set<MailingList>().Add(mailingList);
            context.SaveChanges();

            return RedirectToAction("Details", "MailingList", new { @id = mailingList.Id});
        }

        public IActionResult Details(int id)
        {
            var mailingList = context.Set<MailingList>()
                .Include(m => m.SubscribersLink)
                .Single(m => m.Id == id);

            var subscribers = GetSubscribers(mailingList.SubscribersLink);

            var viewModel = new MailingListDetailsViewModel()
            {
                MailingList = mailingList,
                Subscribers = subscribers
            }; 

            return View(viewModel);
        }

        private object GetSubscribers(List<MailingListSubscriber> subscribersLink)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == id);

            context.Set<MailingList>().Remove(mailingList);

            context.SaveChanges();
        }

        public void Edit(int id, string name)
        {
            var mailingList= context.Set<MailingList>().Single(m => m.Id == id);

            mailingList.UpdateTitle(name);

            context.SaveChanges();            
        }
        [HttpGet]
        public IActionResult AddContacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContacts(int mailingListId, Subscriber[] subscribers) 
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == mailingListId);

            foreach(var subscriber in subscribers)
            {
                var mailingListToSubscriber = new MailingListSubscriber { 
                    MailingList = mailingList,
                    Subscriber  = subscriber
                };

                mailingList.SubscribersLink.Add(mailingListToSubscriber);

                context.SaveChanges();
            }

            return RedirectToAction("Details", "MailingList", new {@id = mailingListId});
        }   
    }
}