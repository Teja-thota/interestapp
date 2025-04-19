using System.Diagnostics;
using interestapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace interestapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            return View(new InterestCalc());
        }

        [HttpPost]
        public IActionResult Index(InterestCalc interest)
        {
            if (ModelState.IsValid)
            {
                return View(interest); // Return the view with the posted data
            }

            return View(interest); // If invalid, return a blank model
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
