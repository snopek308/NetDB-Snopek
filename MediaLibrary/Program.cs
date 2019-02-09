using System;
using NLog;

namespace MediaLibrary
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
                mediaId = 123,
                title = "Greatest Movie Ever, The (2019)",
                director = "Jeff Grissom",
                // timespan (hours, minutes, seconds)
                runningTime = new TimeSpan(2, 21, 23),
                genres = { "Comedy", "Romance" }
            };

            Console.WriteLine(movie.Display());

            Album album = new Album
            {
                mediaId = 321,
                title = "Greatest Album Ever, The (2019)",
                artist = "Jeff's Awesome Band",
                recordLabel = "Universal Music Group",
                genres = { "Rock" }
            };
            Console.WriteLine(album.Display());

            logger.Info("Program ended");
        }
    }
}
