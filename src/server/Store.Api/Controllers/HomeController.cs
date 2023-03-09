using System.Diagnostics;


using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return Json(new List<object>
            {
                new { Id = 1, Name = "Rosen Spiridonov", Description = "This is totally working" },
                new { Id = 2, Name = "Ivaylo Petkov", Description = "This sucks" },
                new { Id = 3, Name = "Georgi Petkov", Description = "This ios the best thing today" },
                new { Id = 4, Name = "Petar Dimitrov", Description = "Pow pow pow" }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}