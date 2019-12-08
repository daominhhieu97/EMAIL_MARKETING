using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class TemplateController : Controller
    {
        private readonly ProjectContext context;

        public TemplateController(ProjectContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var viewModel = new Template();

            return View(viewModel);
        }

        public IActionResult Create(Template template)
        {
            var templateModel = template;
            context.Set<Template>().Add(templateModel);
            context.SaveChanges();

            return RedirectToAction("Details", new { id = templateModel.Id });
        }

        public IActionResult GetTemplates()
        {
            var templates = context.Set<Template>().ToList();
            return View(templates);
        }

        public IActionResult Details(int id)
        {
            var template = context.Set<Template>().Single(t => t.Id == id);

            return View(template);
        }
    }
}