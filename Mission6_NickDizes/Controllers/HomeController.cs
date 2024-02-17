using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
