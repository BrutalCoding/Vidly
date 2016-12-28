using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie1 = new Movie() { Name = "Shrek! - The Movie" };
            var movie2 = new Movie() { Name = "Terminator" };
            var viewModel = new IndexMovieViewModel()
            {
                Movies = new List<Movie> { movie1, movie2 }
            };
            return View(viewModel);
        }
        
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shrek! - The Movie" };
            var customer1 = new Customer() { Name = "Daniel" };
            var customer2 = new Customer() { Name = "Jacky" };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = new List<Customer> { customer1, customer2}
            };
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"parameters: {year} and {month}");
        }
    }
}