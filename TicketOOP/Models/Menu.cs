using System;
using System.Linq;

namespace TicketOOP.Models
{
    public class Menu
    {
        public Menu()
        {
            Console.WriteLine("------- MENU --------");
            Console.WriteLine("(R)ead the ticket data");
            Console.WriteLine("(C)reate Tickets");
            Console.WriteLine("(Q)uit");
        }
        public char GetUserInput()
        {
            char selection;

            Console.Write("?");
            while (!IsValidInput(Console.ReadKey(true).KeyChar, out selection))
            {
                Console.WriteLine($"Invalid input: {selection}");
                Console.WriteLine();
                Console.WriteLine("Please enter (R)ead, (C)reate, or (Q)uit");
                Console.Write("?");
            }

            Console.WriteLine();
            return selection;
        }

        private bool IsValidInput(char input, out char selection)
        {
            char[] validValues = { 'R', 'r', 'C', 'c', 'Q', 'q' };

            selection = Char.ToUpper(input);
            if (validValues.Contains(input))
            {
                return true;
            }

            return false;
        }
    }
}
