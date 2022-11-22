using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class Music
    {
        private string id;
        private string title;
        private string artist;
        private string[] genre;
        private int year;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string[] Genre { get => genre; set => genre = value; }
        public int Year { get => year; set => year = value; }

        public Music(string Id, string Title, string Artist, string[] Genre, int Year)
        {
            this.Id = Id;
            this.Title = Title;
            this.Artist = Artist;
            this.Genre = Genre;
            this.Year = Year;
        }
    }
}
