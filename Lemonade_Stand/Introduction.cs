using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Introduction
    {
        public Introduction()//constructor
        {

        }
        public void ShowIntro()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("WELCOME to LEMONADE STAND");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nYou have 7 days to try and make a profit." +
                "\nYou will need to determine your recipe, buy your ingredients, at set your selling price to do this." +
                "\nYou should also watch the weather forecasts.  The weather could affect your sales." +
                "\nGood Luck!!");
            Console.ResetColor();
        }
    }//class
}//namespace
