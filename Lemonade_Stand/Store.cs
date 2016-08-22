using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        public string yesOrNo;
        public double price;
        public double money;
        public double moneySpent;
        public double profit;
        public int choiceLemons;
        public int choiceIce;
        public int choiceCups;
        public int choiceSugar;
        Inventory inventory = new Inventory();
        Weather weather = new Weather();
        List<int> customerBuysLemonade = new List<int>();
        List<int> customerDoesntBuyLemonade = new List<int>();


        public Store()//constructor
        {

        }

        public double BuyLemons()
        {

            Console.WriteLine($"You currently have {inventory.lemons} Lemons.");
            Console.Write("How many Lemons would you like to buy? Lemons cost 10 cents.\nLemons to Buy:  ");
            try
            {
                choiceLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyLemons();
            }
            if (inventory.money - (choiceLemons * .10) < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                Console.ResetColor();
                BuyLemons();
            }
            else
            {
                Console.Write($"Are you sure you want to buy {choiceLemons}?  Y/N  ");
                yesOrNo = Console.ReadLine().ToLower();
                switch (yesOrNo)
                {
                    case "y":
                        inventory.lemons = inventory.lemons + choiceLemons;
                        inventory.money = inventory.money - (choiceLemons * .1);
                        Console.WriteLine($"You have purchased {choiceLemons} lemons");
                        Thread.Sleep(50);
                        Console.Clear();
                        weather.ShowDailyWeather();
                        inventory.ShowCash();
                        break;
                    case "n":
                        BuyLemons();
                        break;
                    default:
                        Console.WriteLine("Your entry is invalid. Please try again");
                        BuyLemons();
                        break;
                }
            }

            return inventory.money;
        }

        public double BuyCups()
        {
            Console.WriteLine($"You currently have {inventory.cups} Cups.");
            Console.Write("How many Cups would you like to buy? Cups are $0.05 each.\nCups to Buy:  ");
            try
            {
                choiceCups = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyCups();
            }
            if (inventory.money - (choiceCups * .05) < 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                Console.ResetColor();
                return BuyCups();
            }
            else
            {
                Console.Write($"Are you sure you want to buy {choiceCups}?  Y/N   ");
                yesOrNo = Console.ReadLine();
                switch (yesOrNo)
                {
                    case "y":
                        inventory.cups = inventory.cups + choiceCups;
                        inventory.money = inventory.money - (choiceCups * .05);
                        Console.WriteLine($"You have purchased {choiceCups} cups");
                        Thread.Sleep(50);
                        Console.Clear();
                        weather.ShowDailyWeather();
                        inventory.ShowCash();
                        break;
                    case "n":
                        return BuyCups();
                    default:
                        Console.WriteLine("Please try again");
                        return BuyCups();
                }
            }

            return inventory.money;
        }

        public double BuyIce()
        {
            Console.WriteLine($"You currently have {inventory.ice} Cups of Ice.");
            Console.Write("How many Cups of Ice would you like to buy? Cups cost 5 cents each.\nIce to Buy:  ");
            try
            {
                choiceIce = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuyIce();
            }
            if (inventory.money - (choiceIce * .05) < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                Console.ResetColor();
                return BuyIce();
            }
            else
            {
                Console.Write($"Are you sure you want to buy {choiceIce} Cups of Ice?  Y/N  ");
                yesOrNo = Console.ReadLine();
                switch (yesOrNo)
                {
                    case "y":
                        inventory.ice = inventory.ice + choiceIce;
                        inventory.money = inventory.money - (choiceIce * .05);
                        Console.WriteLine($"You have purchased {choiceIce} ice");
                        Thread.Sleep(200);
                        Console.Clear();
                        weather.ShowDailyWeather();
                        inventory.ShowCash();
                        break;
                    case "n":
                        return BuyIce();
                    default:
                        Console.WriteLine("Please try again");
                        return BuyIce();
                }
            }

            return inventory.money;
        }

        public double BuySugar()
        {
            Console.WriteLine($"You currently have {inventory.sugar} Servings of Sugar.");
            Console.Write("How many servings of Sugar would you like to buy? A serving of Sugar is 2 cents each.\nSugar to Buy:  ");
            try
            {
                choiceSugar = int.Parse(Console.ReadLine());
                if (choiceSugar + inventory.sugar < inventory.lemons * 2 && choiceSugar + inventory.sugar < inventory.ice * 2 && choiceSugar + inventory.sugar < inventory.cups * 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Will that be enough?  Would you like to try again?  ");
                    Console.ResetColor();
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "y":
                            return BuySugar();
                        case "n":
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a positive whole number, or zero");
                return BuySugar();
            }
            if (inventory.money - (choiceSugar * .02) < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry you do not have enough money to make that purchase. Please try again.");
                Console.ResetColor();
                return BuySugar();
            }


            else
            {
                Console.Write($"Are you sure you want to buy {choiceSugar} Servings of Sugar?  Y/N  ");
                yesOrNo = Console.ReadLine();
                switch (yesOrNo)
                {
                    case "y":
                        inventory.sugar = inventory.sugar + choiceSugar;
                        inventory.money = inventory.money - (choiceSugar * .02);
                        Console.WriteLine($"You have purchased {choiceSugar} sugar");
                        Thread.Sleep(200);
                        Console.Clear();
                        weather.ShowDailyWeather();
                        inventory.ShowCash();
                        break;
                    case "n":
                        return BuySugar();
                    default:
                        Console.WriteLine("Please try again");
                        return BuySugar();
                }
            }

            return inventory.money;

        }

        public double SetPrice()
        {
            try
            {
                Console.WriteLine("Please enter how much you would like to charge per cup for the day. \nFor example, 50 cents per cup would be entered as .50");
                price = double.Parse(Console.ReadLine());
                if (price <= 0.009)
                {
                    Console.WriteLine("You're Trying to make a profit, right?");
                    SetPrice();
                }
                else if (price >= 2.00)
                {
                    Console.WriteLine("Are you sure your lemonade is worth that?");
                    SetPrice();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please try again");
                return SetPrice();
            }
            return price;
        }
        public void SetWillBuyPrice()
        {
            customerBuysLemonade.Clear();
            customerDoesntBuyLemonade.Clear();
            Random customerBuys = new Random();
            Thread.Sleep(5);
            foreach (int buyer in weather.customerApproaching)
            {

                int priceBuy = customerBuys.Next(0, 100);
                if (price > 0 && price <= .2)
                {
                    if (inventory.enoughInventory == true)
                    {
                        weather.willBuy = true;
                        customerBuysLemonade.Add(1);
                        inventory.SubtractInventory();
                        inventory.money = inventory.money + price;
                    }
                    else
                        break;

                }

                if (price > .2 && price <= .5)
                {
                    if (priceBuy < 80)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            customerBuysLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + price;
                        }
                        else
                            break;
                    }
                    else
                    {
                        customerDoesntBuyLemonade.Add(1);
                    }
                }

                if (price > .5 && price <= .75)
                {
                    if (priceBuy < 70)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            customerBuysLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + price;
                        }
                        else
                            break;
                    }
                    else
                    {
                        customerDoesntBuyLemonade.Add(1);
                    }
                }

                if (price > .75 && price <= 1)
                {
                    if (priceBuy < 60)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            customerBuysLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + price;
                        }
                        else
                            break;
                    }
                    else
                    {
                        customerDoesntBuyLemonade.Add(1);
                    }
                }

                if (price > 1 && price <= 1.25)
                {
                    if (priceBuy < 40)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            customerBuysLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + price;
                        }
                        else
                            break;
                    }
                    else
                    {
                        customerDoesntBuyLemonade.Add(1);
                    }
                }

                if (price > 1.25 && price <= 1.5)
                {
                    if (priceBuy < 30)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            customerBuysLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + price;
                        }
                        else
                            break;
                    }
                    else
                    {
                        customerDoesntBuyLemonade.Add(1);
                    }
                }

                if (price > 1.5)
                {
                    if (priceBuy < 10)
                    {
                        if (inventory.CheckInventory())
                        {
                            weather.willBuy = true;
                            customerBuysLemonade.Add(1);
                            inventory.SubtractInventory();
                            inventory.money = inventory.money + price;
                        }
                        else
                            break;
                    }
                    else
                    {
                        customerDoesntBuyLemonade.Add(1);
                    }
                }
            }

        }

        public double ShowMoney()
        {
            money = inventory.money;
            Console.WriteLine($"You have {money:C2}");
            return money;
        }

        public void ShowApproachingCustomers()
        {
            int approachingCustomers = customerBuysLemonade.Count + customerDoesntBuyLemonade.Count;
            if (approachingCustomers == 1)
            {
                Console.WriteLine("One customer came to buy Lemonade");
            }
            else
                Console.WriteLine($"{approachingCustomers} customers came to buy Lemonade.");
        }

        public void ShowPurchased()
        {
            if (customerBuysLemonade.Count == 1)

            {
                Console.WriteLine("One person bought Lemonade!!");
            }

            else
            {
                Console.WriteLine($"{customerBuysLemonade.Count()} bought Lemonade!!!");
            }

        }

        public void ShowDidNotPurchase()
        {
            if (customerDoesntBuyLemonade.Count == 1)
            {
                Console.WriteLine("One person didn't buy Lemonade because the price was too high");
            }
            else
            {
                Console.WriteLine($"{customerDoesntBuyLemonade.Count()} people didn't buy Lemonade because the price was too high");
            }

        }

        public double ShowMoneySpent()
        {
            moneySpent = ((choiceCups * .05) + (choiceIce * .05) + (choiceLemons * .1) + (choiceSugar * .02));
            Console.WriteLine($"You spent {moneySpent:C2} dollars on inventory.");
            return moneySpent;
        }

        public double ShowProfit()
        {

            profit = inventory.money - 15;
            Console.WriteLine($"Current Total Profit : {profit:C2}");
            return profit;
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"Your current Inventory is: ");
            Console.WriteLine($"Inventory: {inventory.lemons} Lemons");
            Console.WriteLine($"Inventory: {inventory.sugar} Servings of Sugar");
            Console.WriteLine($"Inventory: {inventory.cups} Cups");
            Console.WriteLine($"Inventory: {inventory.ice} Cups of Ice");

        }

        public void ShowWeather()
        {
            weather.ShowDailyWeather();
        }
        public void MeltIce()
        {
            inventory.ice = 0;
        }
        public void GetWeather()
        {
            inventory.ShowCash();
            inventory.ShowInventory();
            weather.DetermineWeather();
            weather.StateForecasat();
            weather.GetNumberOfPotentialCustomers();
            weather.DetermineWillBuyWeather();

        }
    }//class
}//namespace