using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Infrastructure;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Subscribers;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class MailingListController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly ProjectContext context;

        public MailingListController(ProjectContext projectContext, IToastNotification toastNotification)
        {
            this.context = projectContext;
            this.toastNotification = toastNotification;
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

            toastNotification.AddSuccessToastMessage($"Created new {mailingList.Title} successfully.");

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
                AddSegmentationViewModel = new AddSegmentationViewModel
                {
                    MailingListId = mailingList.Id,
                    Areas = subscribers.GroupBy(x => x.Area).Select(x => new SelectListItem(x.Key, x.Key)).OrderBy(x => x.Value).ToArray(),
                    Cities = subscribers.GroupBy(x => x.City).Select(x => new SelectListItem(x.Key, x.Key)).OrderBy(x => x.Value).ToArray()
                },
                AddContactsViewModel = new AddContactsViewModel { MailingListId = mailingList.Id }
            };

            return View(viewModel);
        }

        private List<RFMSubscriber> GetSubscribers(MailingList mailingList)
        {
            List<RFMSubscriber> subscribers = context.Set<MailingListSubscriber>()
                .Where(ms => ms.MailingListId == mailingList.Id)
                .Select(ms => ms.Subscriber)
                .ToList();

            return subscribers;
        }

        public IActionResult Delete(int id)
        {
            var mailingList = context.Set<MailingList>().Single(m => m.Id == id);

            context.Set<MailingList>().Remove(mailingList);

            try
            {
                context.SaveChanges();

                toastNotification.AddSuccessToastMessage($"Deleted {mailingList.Title} mailing list successfully.");
            }
            catch
            {
                toastNotification.AddErrorToastMessage($"Deleted {mailingList.Title} mailing list failed.");
            }
            

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

            toastNotification.AddSuccessToastMessage($"Edited the {mailingList.Title} mailing list successfully");

            return RedirectToAction("Details", "MailingList", new { id = mailingList.Id });
        }

        [HttpPost]
        public async Task<IActionResult> AddContacts(MailingListDetailsViewModel viewModel)
        {
            var mailingList = context.Set<MailingList>()
              .Include(m => m.SubscribersLink)
              .Single(m => m.Id == viewModel.AddContactsViewModel.MailingListId);

            List<RFMSubscriber> subscribers;

            if (viewModel.AddContactsViewModel.RfmModel)
            {
                var converter = ConverterFactory.CreateRFMConverter();
                var parser = ParserFactory.CreateRFMParser();
                subscribers = await AddContactsByRFMModel(viewModel.AddContactsViewModel.File, viewModel.AddContactsViewModel.Subscribers, parser, converter);
            }
            else
            {
                var converter = ConverterFactory.CreateUsualConverter();
                var parser = ParserFactory.CreateUsualParser();
                subscribers = await AddContactsAsUsual(viewModel.AddContactsViewModel.File, viewModel.AddContactsViewModel.Subscribers, parser, converter);
            }

            AddMailingListSubscribersToDb();

            context.SaveChanges();

            toastNotification.AddSuccessToastMessage("Add contacts successfully");

            return RedirectToAction("Details", new { id = mailingList.Id });

            void AddMailingListSubscribersToDb()
            {
                foreach (var mlSub in subscribers.Select(rfmSubscriber => new MailingListSubscriber
                {
                    MailingList = mailingList,
                    Subscriber = rfmSubscriber
                }))
                {
                    mailingList.SubscribersLink.Add(mlSub);
                }
            }
        }

        private async Task<List<RFMSubscriber>> AddContactsByRFMModel(IFormFile file, string subscribers, SubscriberParser parser, SystemConverter converter)
        {
            var result = new List<RFMSubscriber>();

            if (subscribers != null)
            {
                result = parser.Parse(subscribers);
            }
            else
            {
                result = await converter.Convert(file);
            }

            return result;
        }

        private async Task<List<RFMSubscriber>> AddContactsAsUsual(IFormFile file, string subscribers, SubscriberParser parser, SystemConverter converter)
        {
            var result = new List<RFMSubscriber>();

            if (subscribers != null)
            {
                result = parser.Parse(subscribers);
            }
            else
            {
                result = await converter.Convert(file);
            }

            return result;
        }

        public async Task<string> ReadFromCsvFile(Stream openReadStream)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(openReadStream))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(await reader.ReadLineAsync());
            }
            return result.ToString();
        }

        public IActionResult EditSubscriber()
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteSubscriber(int id, int mailinglistId)
        {
            var a = context.Set<MailingListSubscriber>()
                .Single(mls => mls.SubscriberId == id && mls.MailingListId == mailinglistId);

            context.Set<MailingListSubscriber>().Remove(a);

            context.SaveChanges();

            return RedirectToAction("Details", "MailingList", new { id = mailinglistId });
        }
    }
}