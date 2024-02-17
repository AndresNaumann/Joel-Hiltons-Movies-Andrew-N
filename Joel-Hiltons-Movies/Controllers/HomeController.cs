using Joel_Hiltons_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Joel_Hiltons_Movies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View("Movies");
        }

        [HttpPost]
        public IActionResult Movies(Application response)
        {
            return View("Confirmation", response);
        }
       
    }
}
