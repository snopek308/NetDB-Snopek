using System;
using System.Collections.Generic;
using NLog;

namespace MovieLibrary
{
    class MainClass
    {
        // create a class level instance of logger (can be used in methods other than Main)
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            logger.Info("Program started");

            Movie movie = new Movie
            {
                movieId = 1,
                title = "Jeff's Killer Movie (2019)",
                genres = new List<string> { "Action", "Romance", "Comedy" }
            };

            Console.WriteLine(movie.Display());

            logger.Info("Program ended");
        }
    }
}
