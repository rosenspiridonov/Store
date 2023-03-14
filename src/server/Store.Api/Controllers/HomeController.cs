using System.Diagnostics;


using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new List<object>
            {
                new { Id = 1, Name = "Rosen Spiridonov", Description = "This is totally working" },
                new { Id = 2, Name = "Ivaylo Petkov", Description = "This sucks" },
                new { Id = 3, Name = "Georgi Petkov", Description = "This ios the best thing today" },
                new { Id = 4, Name = "Petar Dimitrov", Description = "Pow pow pow" }
            });
        }
    }
}