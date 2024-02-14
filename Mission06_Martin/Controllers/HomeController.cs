using Microsoft.AspNetCore.Mvc;
using Mission06_Martin.Models;
using System.Diagnostics;

namespace Mission06_Martin.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDatabaseContext _context;

        public HomeController(MoviesDatabaseContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieDatabase()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieDatabase(Movie response)
        {

            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }


    }
}
