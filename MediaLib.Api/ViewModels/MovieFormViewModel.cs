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
        [Display(Name = "Medium")]
        public IEnumerable<Media> Media { get; set; }
        //public Movie Movie { get; set; }
        [Required]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Bitte trage einen Namen ein.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bitte gib ein Genre an.")]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Required(ErrorMessage = "Bitte gib ein Medium an.")]
        public int? MediumId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
        }
    }
}