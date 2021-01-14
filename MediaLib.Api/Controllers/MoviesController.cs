using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaLib.Data.Models;
using System.Data.Entity;
using MediaLib.Api.ViewModels;
using System.Data.Entity.Validation;

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
            var genres = _context.MovieGenres.ToList();
            var media = _context.Media.ToList();
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                MovieGenres = genres,
                Media =  media
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    MovieGenres = _context.MovieGenres.ToList(),
                    Media = _context.Media.ToList()
                };

                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.Medium = movie.Medium;
                movieInDb.Genre = movie.Genre;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

          
           _context.SaveChanges();
           

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                MovieGenres = _context.MovieGenres.ToList()
            };
            return View("MovieForm", viewModel);
        }
    }
}