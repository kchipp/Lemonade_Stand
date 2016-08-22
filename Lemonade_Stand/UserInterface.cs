using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class UserInterface
    {

        public UserInterface()//constructor
        {

        }

        public void IntoduceGame()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  ***WELCOME to LEMONADE STAND!!***  ");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Player player = new Player();
            Console.WriteLine($"\nAlright {player.Name1}...here we go...");
            Console.ResetColor();
            Console.WriteLine("You've got 7 days to see if you can make buid a successful Lemonade stand." +
                "\nYou'll need to figure out the best recipe for good Lemonade" +
                "\nBuy supplies to make your lemonade.  Then set your price to sell your lemonade for the day");
            Console.WriteLine("Couple of hints...ice only lasts for the day and weather and/or price could affect your sales");
            Console.WriteLine("You start the game with $15.00.");
            Console.WriteLine("Press any key to start the game!!!");
            Console.ReadKey();

            Console.Clear();
        }
    }//class
}//namespace
