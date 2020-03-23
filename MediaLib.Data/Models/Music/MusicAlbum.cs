using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLib.Data.Models.Music
{
    public class MusicAlbum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MusicArtist Artist { get; set; }
        public List<Song> Songs { get; set; }
        public MusicGenre Genre { get; set; }
        public float Length { get; set; }
        
    }
}