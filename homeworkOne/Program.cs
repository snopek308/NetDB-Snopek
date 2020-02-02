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
            int ticketID = 0;
            string summary;
            string status;
            string priority;
            string submmitter;
            string assigned;
            string watching;

            do
            {
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
                            Console.WriteLine(arr[0] + ", " + arr[1] + ", " + arr[2] + ", " + arr[3] + ", " + arr[4] + ", " + arr[5] + ", " + arr[6]);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }

                else if (choice == "2")
                {

                    string response;  // to capture user responses

                    do
                    {
                        // ask user if they wish to enter a new ticket
                        Console.WriteLine("Enter a ticket (Y/N)?");
                        // capture user response
                        response = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        
                        if (response != "Y") { break; }

                        // assign a ticketID
                        ticketID = ticketID + 2;
                        Console.WriteLine($"Creating a new ticket under Ticket ID : {ticketID}");

                        // prompt for ticket summary and save ticket summary to a variable
                        Console.WriteLine("Enter a new ticket summary: ");
                        summary = Console.ReadLine();

                        // prompt for ticket status and savingh it to a variable
                        Console.WriteLine("Enter the ticket status: ");
                        status = Console.ReadLine();

                        // prompt for ticket priority and saving it to a variable
                        Console.WriteLine("Enter the ticket priority: ");
                        priority = Console.ReadLine();

                        // prompt for submittedBy, and saved to a variable
                        Console.WriteLine("Enter ticket submitter's full name: ");
                        submmitter = Console.ReadLine();

                        // prompt for assigned and saved to a variable
                        Console.WriteLine("Enter full name ticket is to be assigned to: ");
                        assigned = Console.ReadLine();

                        // prompt for watching and saved to a variable
                        Console.WriteLine("Enter full name of person watching the ticket: ");
                        watching = Console.ReadLine();

                        StreamWriter sw = new StreamWriter(file, append: true);

                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}",
                            ticketID, summary, status, priority, submmitter, assigned, watching);

                        sw.Close();

                    } while (response != "N"); // do while loop for option two, continue adding records
                }

            } while (choice == "1" || choice == "2");
        }
    }

}
