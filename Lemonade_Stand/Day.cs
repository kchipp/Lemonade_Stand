using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        Game game = new Game();
        Player player = new Player();
        public Day()//constructor
        {

        }

        public void DecideToPlay()
        {

            Console.WriteLine($"Want to play a little game, {player.Name1}?");
            Console.WriteLine();
            Console.WriteLine("Y for yes");
            Console.WriteLine("N for no");

            String choice;
            choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "Y":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("GREAT!!!  Press enter:  ");
                    game.StartGame();
                    Console.Clear();

                    break;
                case "N":
                    Console.WriteLine("Aww.  Well, maybe next time.");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("What's that??");
                    DecideToPlay();
                    break;
            }
        }

    }//class
}//namespace