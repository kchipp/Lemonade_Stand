using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        public int lemons;
        public int ice;
        public int cups;
        public int sugar;
        public double money = 15.00;
        public bool enoughInventory;

        public Inventory()//constructor
        {

        }

        public void SubtractInventory()
        {
            lemons = lemons - 1;
            ice = ice - 1;
            sugar = sugar - 2;
            cups = cups - 1;
        }

        public bool CheckInventory()
        {
            if (lemons >= 1 && ice >= 1 && sugar >= 2 && cups >= 1)
                enoughInventory = true;
            else
            {
                enoughInventory = false;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You ran out of product before you could serve all your customers!! Buy more and try again tomorrow!!");
                Console.ResetColor();
            }

            return enoughInventory;
        }
        public void ShowCash()
        {

            Console.WriteLine($"Money: {money:C2}");

        }
        public void ShowInventory()
        {
            Console.WriteLine($"Inventory: {lemons} Lemons, {sugar} Servings of Sugar, {cups} Cups, {ice} Cups of Ice");

        }

    }//class
}//namespace

