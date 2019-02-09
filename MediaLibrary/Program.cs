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
                genres = { "Comedy", "Romance" }
            };

            Console.WriteLine(movie.Display());

            logger.Info("Program ended");
        }
    }
}
