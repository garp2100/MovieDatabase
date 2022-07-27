using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        public Movie(string argTitle, string argCategory) //constructor for the movie object passing a string and an enum
        {
            Title = argTitle;
            Category = argCategory;
        }
        public string Title { get; set; }
        public string Category { get; set; }

        public void PrintMovieSelection()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Category + "\n");
        }
    }
}
