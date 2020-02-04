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
                    int[] hours = new int[7];
                    for (int i = 0; i < hours.Length; i++)
                    {
                        // generate random number of hours slept between 4-12 (inclusive)
                        hours[i] = rnd.Next(4, 13);
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
                        Console.WriteLine("Su Mo Tu We Th Fr Sa");
                        Console.WriteLine("-- -- -- -- -- -- --");
                        Console.WriteLine("|{0,4}|{1, 6}|", arrTwo[1] + " " + arrTwo[2] + " " + arrTwo[3] + " " + arrTwo[4] + " " + arrTwo[5] + " " + arrTwo[6] + " " + arrTwo[7]);
                    }

            }
        }
    }
}
