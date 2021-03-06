﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaLib.Data.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bitte trage einen Namen ein.")]
        [StringLength(255)]
        public string Name { get; set; }

        //[Display(Name = "Release date")]
        //public DateTime? ReleaseDate { get; set; }

        //public DateTime DateAdd { get; set; }
        public MovieGenre Genre { get; set; }

        [Required(ErrorMessage = "Bitte gib ein Genre an.")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public List<MovieActor> Actors { get; set; }

        public Media Medium { get; set; }

        [Required(ErrorMessage = "Bitte gib ein Medium an.")]
        public int MediumId { get; set; }
    }
}