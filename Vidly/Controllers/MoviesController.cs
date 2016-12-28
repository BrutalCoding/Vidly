using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return View(new Movie());
            }
            else
            {
                Movie movie = _context.Movies.SingleOrDefault(m => m.Id == id.Value);
                if (movie == null)
                    return View(new Movie());
                return View(movie);
            }
        }
    }
}