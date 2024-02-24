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

        // Create a movie to put into the list

        [HttpGet]
        public IActionResult Movies() // Form for adding movies page
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View("Movies", new Application());
        }

        // Only let in valid data into the database

        [HttpPost]
        public IActionResult Movies(Application response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add the record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else // Invalid Data
            {
                ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }
        
        }

        // List of Joel's movies

        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        [HttpGet] // Edit a record
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("Movies", recordToEdit);
        }

        [HttpPost] // Post the edits to the database
        public IActionResult Edit(Application updated)
        {
            _context.Update(updated);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet] // Delete a record from the database
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies.Single(x => x.MovieId == id);

            return View(recordToDelete);

        }

        [HttpPost] // Post it to the database
        public IActionResult Delete(Application deleted)
        {
            _context.Movies.Remove(deleted);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
