using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns;
using Microsoft.AspNetCore.Mvc;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            Template viewModel = new Template();

            return View(viewModel);
        }
    }
}