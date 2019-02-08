using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    public class Movie
    {
        // public properties
        public UInt64 movieId { get; set; }
        //public string title { get; set; }
        public List<string> genres { get; set; }
        // private field
        string _title;
        public string title
        {
            get
            {
                return this._title;
            }
            set
            {
                // if there is a comma(,) in the title, wrap it in quotes
                this._title = value.IndexOf(',') != -1 ? $"\"{value}\"" : value;
            }
        }

        // constructor
        public Movie()
        {
            genres = new List<string>();
        }

        // public method
        public string Display()
        {
            return $"Id: {movieId}\nTitle: {title}\nGenres: {string.Join(", ", genres)}\n";
        }
    }
}
