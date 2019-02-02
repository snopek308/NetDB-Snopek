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
            string file = "../../movies.csv";
            logger.Info("Program started");

            MovieFile movieFile = new MovieFile(file);

            logger.Info("Program ended");
        }
    }
}
