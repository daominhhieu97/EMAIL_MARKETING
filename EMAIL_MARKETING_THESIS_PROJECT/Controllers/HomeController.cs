using System.Linq;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Models.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMAIL_MARKETING_THESIS_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectContext context;

        public HomeController(ProjectContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var customer = new Customer();

            return View(customer);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer customer)
        {
            if (CustomerRegistered(customer))
            {
                return RedirectToAction("Index", "Campaign");
            }

            return RedirectToAction("Index");
        }

        private bool CustomerRegistered(Customer customer)
            => context.Set<Customer>().Any(x => x.Username == customer.Username && x.Password == customer.Password);

        public IActionResult Register()
        {
            var customer = new Customer();

            return View(customer);
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            context.Set<Customer>().Add(customer);

            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}