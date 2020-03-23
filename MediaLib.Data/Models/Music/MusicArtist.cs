using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLib.Data.Models.Music
{
    public class MusicArtist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MusicGenre Genre { get; set; }
    }
}