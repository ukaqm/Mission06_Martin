using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult JoelHiltonMovieCollection()
        {
            ViewBag.categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult JoelHiltonMovieCollection(Movie movie)
        {

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View("Confirmation", movie);
        }

        public IActionResult MovieDatabaseViewPoint()
        {
            var movieSet = _context.Movies.Include(x => x.Category).ToList();
            return View(movieSet);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.categories = _context.Categories.ToList();

            return View("JoelHiltonMovieCollection", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();

            return RedirectToAction("MovieDatabaseViewPoint");
        }
    }
}
