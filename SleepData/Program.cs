using System;
using System.IO;

namespace SleepData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ask for input
            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            // input response
            string resp = Console.ReadLine();

            // specify path for data file
            //string file = "/users/jgrissom/downloads/data.txt"; <This is what it was before
            //makes the file
            string file = AppDomain.CurrentDomain.BaseDirectory + "data.txt";

            if (resp == "1")
            {
                // create data file

                // ask a question
                Console.WriteLine("How many weeks of data is needed?");
                // input the response (convert to int)
                int weeks = int.Parse(Console.ReadLine());

                // determine start and end date
                DateTime today = DateTime.Now;
                // we want full weeks sunday - saturday
                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
                // subtract # of weeks from endDate to get startDate
                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));

                // random number generator
                Random rnd = new Random();

                // create file
                StreamWriter sw = new StreamWriter(file);
                // loop for the desired # of weeks
                while (dataDate < dataEndDate)
                {
                    // 7 days in a week
                    int[] hours = new int[9];
                    int total = 0;
                    int average = 0;
                    for (int i = 0; i < hours.Length; i++)
                    {
                        var x = rnd.Next(4, 13);
                        // generate random number of hours slept between 4-12 (inclusive)
                        if (i < 7)
                        {
                            hours[i] = x;
                            total += x;
                        }

                        if (i == 8)
                        {
                            hours[i] = total;
                        }
                        if (i == 9)
                        {
                            hours[i] = total / 7;
                        }
                        
                    }
                    // M/d/yyyy,#|#|#|#|#|#|#
                    //Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
                    sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
                    // add 1 week to date
                    dataDate = dataDate.AddDays(7);
                }
                sw.Close();
            }
            else if (resp == "2")
            {
                using (StreamReader sw = new StreamReader("data.txt"))
                    while (!sw.EndOfStream)
                {
                        String dateResult;
                        string dataDate = sw.ReadLine();

                        //split the dates and the numbers, makes the arr[0] into a string and then parses it to a DateTime
                        string[] arrOne = dataDate.Split(',');
                        dateResult = arrOne[0];
                        DateTime dateResultParse = DateTime.Parse(dateResult);
                        
                        //splits the numbers
                        string[] arrTwo = dataDate.Split(',', '|');


                        Console.WriteLine("Week of " + dateResultParse.ToString("MMM, dd, yyyy"));
                        Console.WriteLine($"{"Su",3}{"Mo",3}{"Tu",3}{"We",3}{"Th",3}{"Fr",3}{"Sa",3}{"Tot", 4}{"Avg", 4}");
                        Console.WriteLine($"{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",4}{"--",4}"); // {"---",4}{"---",4}");
                        Console.WriteLine($"{arrTwo[1],3}{arrTwo[2],3}{arrTwo[3],3}{arrTwo[4],3}{arrTwo[5],3}{arrTwo[6],3}{arrTwo[7],3}{arrTwo[8], 4}{arrTwo[9], 4}");
                    }

            }
        }
    }
}





//using System;
//using System.IO;
//using NLog;

//namespace SleepData
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            // create NLog configuration
//            var config = new NLog.Config.LoggingConfiguration();

//            // define targets
//            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "log_file.txt" };
//            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

//            // specify minimum log level to maximum log level and target (console, file, etc.)
//            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logconsole);
//            config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);

//            // apply NLog configuration
//            NLog.LogManager.Configuration = config;

//            // create instance of LogManager
//            var logger = NLog.LogManager.GetCurrentClassLogger();
//            logger.Info("Program started");

//            // ask for input
//            Console.WriteLine("Enter 1 to create data file.");
//            Console.WriteLine("Enter 2 to parse data.");
//            Console.WriteLine("Enter anything else to quit.");
//            // input response
//            string resp = Console.ReadLine();

//            // specify path for data file
//            string file = "/users/jgrissom/downloads/data.txt";

//            if (resp == "1")
//            {
//                // create data file

//                // ask a question
//                Console.WriteLine("How many weeks of data is needed?");
//                // input the response (convert to int)
//                string ans = Console.ReadLine();
//                int weeks;
//                if (!int.TryParse(ans, out weeks))
//                {
//                    logger.Error("Invalid input (integer): {Answer}", ans);
//                }
//                else
//                {
//                    // determine start and end date
//                    DateTime today = DateTime.Now;
//                    // we want full weeks sunday - saturday
//                    DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
//                    // subtract # of weeks from endDate to get startDate
//                    DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));

//                    // random number generator
//                    Random rnd = new Random();

//                    // create file
//                    StreamWriter sw = new StreamWriter(file);
//                    // loop for the desired # of weeks
//                    while (dataDate < dataEndDate)
//                    {
//                        // 7 days in a week
//                        int[] hours = new int[7];
//                        for (int i = 0; i < hours.Length; i++)
//                        {
//                            // generate random number of hours slept between 4-12 (inclusive)
//                            hours[i] = rnd.Next(4, 13);
//                        }
//                        // M/d/yyyy,#|#|#|#|#|#|#
//                        //Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
//                        sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
//                        // add 1 week to date
//                        dataDate = dataDate.AddDays(7);
//                    }
//                    sw.Close();
//                }
//            }
//            else if (resp == "2")
//            {
//                // parse data file
//                if (File.Exists(file))
//                {
//                    // read data from file
//                    StreamReader sr = new StreamReader(file);
//                    while (!sr.EndOfStream)
//                    {
//                        string line = sr.ReadLine();
//                        // convert string to array
//                        // a line of text represents 1 week of data
//                        string[] week = line.Split(',');
//                        // the 1st element in the array is the date
//                        DateTime date = DateTime.Parse(week[0]);
//                        // the 2nd element is the hours of sleep with a "|" delimiter
//                        int[] hours = Array.ConvertAll(week[1].Split('|'), int.Parse);
//                        // display date for the current week
//                        Console.WriteLine($"Week of {date:MMM}, {date:dd}, {date:yyyy}");
//                        // display column headers
//                        Console.WriteLine($"{"Su",3}{"Mo",3}{"Tu",3}{"We",3}{"Th",3}{"Fr",3}{"Sa",3}"); // {"Tot",4}{"Avg",4}");
//                        Console.WriteLine($"{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}"); // {"---",4}{"---",4}");
//                        // display hours of sleep for each day
//                        Console.WriteLine($"{hours[0],3}{hours[1],3}{hours[2],3}{hours[3],3}{hours[4],3}{hours[5],3}{hours[6],3}"); // {hours.Sum(),4}{Math.Round(hours.Sum() / 7.0, 1),4:n1}");
//                        Console.WriteLine();
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("File does not exist");
//                    logger.Warn("File does not exists. {file}", file);
//                }
//            }
//            logger.Info("Program ended");
//        }
//    }
//}
