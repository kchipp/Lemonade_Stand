using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        public int hereTheyCome;

        public Customer()//constructor
        {

        }
        public int EnterCustomer()
        {
            Random announce = new Random();
            Thread.Sleep(5);
            int randomAnnounce = announce.Next(0, 50);
            if (randomAnnounce >= 0 && randomAnnounce <= 10)
            {
                hereTheyCome = 1;
            }
            else if (randomAnnounce >= 11 && randomAnnounce <= 20)
            {
                hereTheyCome = 2;
            }
            else if (randomAnnounce >= 21 && randomAnnounce <= 30)
            {
                hereTheyCome = 3;
            }
            else if (randomAnnounce >= 31 && randomAnnounce <= 40)
            {
                hereTheyCome = 4;
            }
            else if (randomAnnounce >= 41 && randomAnnounce <= 50)
            {
                hereTheyCome = 5;
            }

            return hereTheyCome;
        }

        public void AnnounceCustomersEntering()
        {
            switch (hereTheyCome)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Here they come.  Let's see how you did....");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ready or not, the customers are coming...");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Here come some customers.  Let's see if they like your lemonade...");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Let's sell some Lemonade...");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Are you ready.  Get Set.  Sell...");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }

    }//class
}//namespace
