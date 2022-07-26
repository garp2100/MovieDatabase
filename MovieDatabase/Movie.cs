using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        public Movie(string argTitle, MovieGenre argGenre) //constructor for the movie object passing a string and an enum
        {
            Title = argTitle;
            Genre = argGenre;
        }
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
    }
}
