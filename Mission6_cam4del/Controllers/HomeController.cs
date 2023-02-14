using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_cam4del.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_cam4del.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext movieContext { get; set; }
        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieInfoContext x)
        {
            _logger = logger;
            movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(ar);
                movieContext.SaveChanges();  
            }
            return View("Confirmation", ar);

        }
        public IActionResult Podcasts()
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
