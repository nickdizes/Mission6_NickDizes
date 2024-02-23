using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_NickDizes.Models;
using System.Diagnostics;

namespace Mission6_NickDizes.Controllers
{
    public class HomeController : Controller {

        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
        
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Index");
        }

        public IActionResult MovieList()
        {
      
            var movies = _context.Movies
                .Include(m => m.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
               .OrderBy(x => x.CategoryName)
               .ToList();

            return View("AddMovies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _context.Update(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult DeleteMovie(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);


            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
