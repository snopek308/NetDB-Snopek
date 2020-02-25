using System;
using System.Collections.Generic;

namespace MediaLibrary.Models
{
    //abstract means it can't instiate objects
    //no Media media = new Media();
    //can do movie, book and album bc they are objects of inhertiance
    public abstract class Media
    {
        // public properties
        public UInt64 mediaId { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        // constructor
        public Media()
        {
            genres = new List<string>();
        }

        // public method
        public virtual string Display()
        {
            return $"Id: {mediaId}\nTitle: {title}\nGenres: {string.Join(", ", genres)}\n";
        }
    }

}
