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
        //public string yesOrNo;
        public double price;
        //public double money;
        //public double moneySpent;
        //public double profit;
        ////public int choiceLemons;
        ////public int choiceIce;
        ////public int choiceCups;
        ////public int choiceSugar;
        Inventory inventory = new Inventory();
        Weather weather = new Weather();
        List<int> customerBuysLemonade = new List<int>();
        List<int> customerDoesntBuyLemonade = new List<int>();

        public Customer()//constructor
        {

        }
        public int SeeCustomerEnter()
        {
            Random randomC = new Random();
            Thread.Sleep(5);
            int randomCustomer = randomC.Next(0, 50);
            if (randomCustomer >= 0 && randomCustomer <= 10)
            {
                hereTheyCome = 1;
            }
            else if (randomCustomer >= 11 && randomCustomer <= 20)
            {
                hereTheyCome = 2;
            }
            else if (randomCustomer >= 21 && randomCustomer <= 30)
            {
                hereTheyCome = 3;
            }
            else if (randomCustomer >= 31 && randomCustomer <= 40)
            {
                hereTheyCome = 4;
            }
            else if (randomCustomer >= 41 && randomCustomer <= 50)
            {
                hereTheyCome = 5;
            }

            return hereTheyCome;
        }

        public void AnnounceCustomersComing()
        {
            switch (hereTheyCome)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ready or not, here they come...");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The customers are coming...");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
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
