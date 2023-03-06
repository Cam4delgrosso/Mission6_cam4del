using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieInfoContext movieContext { get; set; }
        //Constructor
        public HomeController(MovieInfoContext x)
        {
            movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            return View("MovieApplication", new ApplicationResponse());
        }

        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(ar);
                movieContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();
                return View();
            }
            

        }
        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var movies = movieContext.responses
                //.Include(x => x.Category)
                .OrderBy(x=> x.title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            var application = movieContext.responses.Single(x => x.MovieId == id);

            return View("MovieApplication", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse edits)
        {
            movieContext.Update(edits);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = movieContext.responses.Single(x => x.MovieId == id);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            movieContext.responses.Remove(ar);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
