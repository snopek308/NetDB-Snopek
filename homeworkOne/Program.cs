using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            string choice;

            // ask user a question
            Console.WriteLine("1) Read data from file.");
            Console.WriteLine("2) Create file from data.");
            Console.WriteLine("Enter any other key to exit.");
            // input response
            choice = Console.ReadLine();

            if (choice == "1")
            {

                if (File.Exists(file))
                {
                    StreamReader ticket = new StreamReader(file);
                    ticket.ReadLine();
                    while (!ticket.EndOfStream)
                    {
                        string line = ticket.ReadLine();
                        // convert string to array
                        string[] arr = line.Split(',');
                        // display array data
                        Console.WriteLine("TicketID, Summary, Status, Priority, Submitter, Assigned, Watching");
                        Console.WriteLine(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }


            }
        }
    }


}

