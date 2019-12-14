using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Infrastructure;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Campaigns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class CampaignController : Controller
    {
        private readonly ProjectContext _context;
        private readonly EmailSender _emailSender;

        public CampaignController(ProjectContext context, EmailSender emailSender)
        {
            this._emailSender = emailSender;
            this._context = context;
        }

        public IActionResult Index()
        {
            var viewModel = _context.Set<Campaign>()
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
                MailingLists = _context.Set<MailingList>().ToList(),
                Templates = _context.Set<Template>().ToList()
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
                MailingList = _context.Set<MailingList>().Single(ml => ml.Id == viewModel.SelectedMailingListId),
                Scheduler = viewModel.Campaign.Scheduler
            };

            var template = _context.Set<Template>().Single(t => t.Id == viewModel.SelectedTemplateId);

            campaign.EmailInfo.Template = template;

            _context.Set<Campaign>().Add(campaign);

            _context.SaveChanges();

            await _emailSender.SendEmail(campaign);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(Campaign viewModel)
        {
            var campaign = _context.Set<Campaign>().Single(c => c.Id == viewModel.Id);

            campaign.Update(viewModel);

            return RedirectToAction("Details", "Campaign", new { id = campaign.Id });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var campaign = _context.Set<Campaign>()
                .Include(c => c.MailingList)
                .Include(c => c.EmailInfo)
                .Include(c => c.Scheduler)
                .Single(c => c.Id == id);

            return View(campaign);
        }

        public IActionResult Delete(int id)
        {
            var campaign = _context.Set<Campaign>().Single(c => c.Id == id);

            _context.Set<Campaign>().Remove(campaign);

            _context.SaveChanges();

            return RedirectToAction("Index", "Campaign");
        }

        public async Task<IActionResult> SendEmailAsync(int id)
        {
            var campaign = _context.Set<Campaign>()
                .Include(c => c.EmailInfo)
                .Include(c => c.MailingList)
                .Include(c => c.Scheduler)
                .Single(c => c.Id == id);

            await _emailSender.SendEmail(campaign);

            return RedirectToAction("Details", new { id = campaign.Id });
        }

        public async Task<IActionResult> Resent(int id)
        {
            var campaign = _context.Set<Campaign>()
                .Include(c => c.EmailInfo)
                .Include(c => c.MailingList)
                .Include(c => c.Scheduler)
                .Single(c => c.Id == id);

            await _emailSender.SendEmail(campaign);

            return RedirectToAction("Details", new { id = campaign.Id });
        }
    }
}