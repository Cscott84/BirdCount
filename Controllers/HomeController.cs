using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using birdsApp2.Models;

namespace birdsApp2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Count()
        {
            return View(birdsApp2.Program.Database.BirdCount);
        }

        [HttpGet]
        public IActionResult AddCount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCount(CountModel entry)
        {
            birdsApp2.Program.Database.BirdCount.Add(entry);
            return Redirect("/home/count");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
