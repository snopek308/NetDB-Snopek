using TicketOOP.Models;

namespace TicketOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var userRequest = menu.GetUserInput();

            TicketManager ticketManager = new TicketManager();
            while (userRequest != 'Q')
            {
                ticketManager.Process(userRequest);
                userRequest = menu.GetUserInput();
            }
        }
    }
}
