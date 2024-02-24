using Joel_Hiltons_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Joel_Hiltons_Movies.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _context;

        public HomeController(ApplicationContext temp) // Constructor
        {
            _context = temp;
        }
        public IActionResult Index() // be able to go to the home page
        {
            return View(); 
        }

        public IActionResult AboutJoel() // Joel's about page
        { 
            return View(); 
        }

        [HttpGet]
        public IActionResult Movies() // Form for adding movies page
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View("Movies");
        }

        [HttpPost]
        public IActionResult Movies(Application response)
        {
            _context.JoelsMovies.Add(response); // Add the record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult MovieList()
        {
            var movies = _context.JoelsMovies.ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.JoelsMovies
                .Single(x => x.MovieID == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("Movies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application updated)
        {
            _context.Update(updated);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
