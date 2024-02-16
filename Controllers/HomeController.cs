using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp) 
        {
            _context = temp;
        }


        //private readonly ILogger<HomeController> _logger;

       // public HomeController(ILogger<HomeController> logger)
        //{
          //  _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetToKnowJoel()
        {
            return View("GetToKnowJoel");
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View("EnterMovie");
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie response)
        {
            _context.Movies.Add(response); //add that record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
