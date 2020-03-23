using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLib.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdd { get; set; }
        public MovieGenre Genre { get; set; }
        public List<MovieActor> Actors { get; set; }
        public Medium Medium { get; set; }
    }
}