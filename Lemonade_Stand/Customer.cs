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

        public void AnnounceCustomersComing()
        {
            Console.Clear();
            Random randomA = new Random();            
            hereTheyCome = randomA.Next(1, 5);
            switch (hereTheyCome)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ready or not, here they come...");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The customers are coming soon...");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It's almost time to open...");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Get the Lemonade in the cups...");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Time to open the store...");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }

    }//class
}//namespace
