using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaLib.Data.Models;
using System.Data.Entity;

namespace MediaLib.Api.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
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
            var movies = _context.Movies.Include(m => m.Genre).Include(m => m.Medium).ToList();

            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).Include(m => m.Medium).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ActionResult New()
        {
            return View();
        }
    }
}