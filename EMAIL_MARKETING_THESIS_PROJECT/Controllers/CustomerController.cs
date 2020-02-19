using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ProjectContext context;

        public CustomerController(ProjectContext context)
        {
            this.context = context;
        }

        public IActionResult Details()
        {
            int? id = int.Parse(HttpContext.Session.GetString("UserId"));

            var customer = context.Set<Customer>().Single(c => c.Id == id);

            return View(customer);
        }
    }
}