using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Templates;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class TemplateController : Controller
    {
        private readonly ProjectContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public TemplateController(ProjectContext context,
            IHostingEnvironment hostingEnvironment)
        {
            this._context = context;
            this._hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateTemplateViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTemplateViewModel viewModel)
        {
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            var uniqueFileName = GetUniqueFileName(viewModel.File.FileName);
            var filePath = Path.Combine(uploads, uniqueFileName);
            var templateModel = new Template
            {
                Name = viewModel.Name,
                Path = filePath
            };

            _context.Set<Template>().Add(templateModel);
            _context.SaveChanges();

            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await viewModel.File.CopyToAsync(fileStream);
            }

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
            var templates = _context.Set<Template>().ToList();
            return View(templates);
        }

        public IActionResult Details(int id)
        {
            var template = _context.Set<Template>().Single(t => t.Id == id);

            return View(template);
        }

        public IActionResult Delete(int id)
        {
            var template = _context.Set<Template>().Single(t => t.Id == id);

            _context.Set<Template>().Remove(template);

            _context.SaveChanges();

            return RedirectToAction("GetTemplates");
        }
    }
}