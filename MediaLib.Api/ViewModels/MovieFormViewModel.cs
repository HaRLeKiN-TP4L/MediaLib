using MediaLib.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaLib.Api.ViewModels
{
    public class MovieFormViewModel
    {
        [Display(Name = "Genre")]
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        public IEnumerable<Medium> Media { get; set; }
        public Movie Movie { get; set; }
    }
}