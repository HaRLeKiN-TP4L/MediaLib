using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaLib.Data.Models;

namespace MediaLib.Api.Controllers
{
    public class MusicController : Controller
    {
        public ActionResult Index()
        {
            var music = new Movie
            {
                Name = "Trailerpark"
            };

            return View(music);
        }
    }
}