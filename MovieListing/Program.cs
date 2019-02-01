using System;
using NLog;

namespace MovieListing
{
    class MainClass
    {
        // create a class level instance of logger (can be used in methods other than Main)
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            // config is loaded using xml (NLog.config saved in  debug folder)
            logger.Info("Program started");

            logger.Info("Program ended");
        }
    }
}
