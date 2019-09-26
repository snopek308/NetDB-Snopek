using System;
using System.Collections.Generic;
using System.Linq;
using TicketOOP.Models;

namespace TicketOOP
{
    public class TicketManager
    {
        private readonly TicketFile _ticketFile;

        public TicketManager()
        {
            _ticketFile = new TicketFile();
        }

        public void Process(char selection)
        {
            switch (selection)
            {
                case 'C':
                    CreateTicket();
                    break;
                case 'R':
                    ShowTickets(_ticketFile.Contents);
                    break;
                case 'Q':
                    break;
            }
        }

        private void ShowTickets(List<Ticket> tickets)
        {
            foreach (var ticket in tickets.Take(10)) Console.WriteLine(ticket.ToString());
        }

        private void CreateTicket()
        {
            var ticket = AskForTicketDetails();
            AddTicketToFile(ticket);
        }

        private Ticket AskForTicketDetails()
        {
            Console.Write("Enter Id: ");
            var id = Console.ReadLine();
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();

            return new Ticket {Id = id, Name = name};
        }

        private void AddTicketToFile(Ticket ticket)
        {
            if (!IsTicketInFile(ticket)) _ticketFile.WriteFile(ticket);
        }

        private bool IsTicketInFile(Ticket ticket)
        {
            return _ticketFile.Contents.Contains(ticket);
        }
    }
}