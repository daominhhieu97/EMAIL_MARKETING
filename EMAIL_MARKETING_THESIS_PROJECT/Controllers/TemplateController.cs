﻿using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Controllers.Common;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Templates;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class TemplateController : Controller
    {
        private readonly ProjectContext context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IToastNotification toastNotification;

        public TemplateController(ProjectContext context,
            IHostingEnvironment hostingEnvironment, IToastNotification toastNotification)
        {
            this.context = context;
            this.hostingEnvironment = hostingEnvironment;
            this.toastNotification = toastNotification;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateTemplateViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTemplateViewModel viewModel)
        {
            var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
            var uniqueFileName = GetUniqueFileName(viewModel.File.FileName);
            var filePath = Path.Combine(uploads, uniqueFileName);
            var templateModel = new Template
            {
                Name = viewModel.Name,
                Content = await viewModel.File.ReadAsStringAsync()
            };

            context.Set<Template>().Add(templateModel);
            context.SaveChanges();

            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await viewModel.File.CopyToAsync(fileStream);
            }

            toastNotification.AddSuccessToastMessage("Created the new template successfully.");

            return RedirectToAction("Details", new { id = templateModel.Id });
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
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

        public IActionResult Delete(int id)
        {
            try
            {
                var template = context.Set<Template>().Single(t => t.Id == id);

                context.Set<Template>().Remove(template);

                context.SaveChanges();

                toastNotification.AddSuccessToastMessage($"Deleted {template.Name} successfully.");
            }
            catch
            {
                toastNotification.AddErrorToastMessage("There was an error.");
            }

            return RedirectToAction("GetTemplates");
        }

        public IActionResult Edit(Template template)
        {
            var templateModel = context.Set<Template>().Single(m => m.Id == template.Id);

            templateModel.Name = template.Name;

            context.SaveChanges();

            toastNotification.AddSuccessToastMessage($"Edited {template.Name} successfully.");

            return RedirectToAction("Details", new { id = templateModel.Id });
        }
    }
}