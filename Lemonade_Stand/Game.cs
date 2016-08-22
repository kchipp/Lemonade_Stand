﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        public int numberOfDays = 2;
        public string choice;
        Store store = new Store();
        Customer customer = new Customer();
        UserInterface ui = new UserInterface();
        Weather weather = new Weather();
        

        public Game()//constructor
        {

        }

        public void StartGame()
        {

            ui.IntoduceGame();
            playGame();

        }

        public void playGame()

        {
            if (store.ShowMoney() > 0)
            {
                for (int day = 1; day <= numberOfDays; day++)

                {
                    Console.Clear();
                    Console.WriteLine($"Day {day} of your Lemonade stand.");
                    store.GetWeather();
                    store.BuyLemons();
                    store.BuyIce();
                    store.BuyCups();
                    store.BuySugar();
                    store.ShowMoneySpent();
                    //store.ShowWeather();
                    store.DisplayInventory();
                    //Console.Clear();
                    Console.WriteLine("Customers will be coming soon...");
                    store.SetPrice();
                    store.SetWillBuyPrice();
                    Console.WriteLine();
                    customer.AnnounceCustomersComing();
                    store.ShowApproachingCustomers();
                    store.ShowPurchased();
                    store.ShowDidNotPurchase();
                    store.ShowProfit();
                    store.MeltIce();
                    Console.WriteLine("Press any key to start the next day");
                    Console.ReadKey();
                }
                EndGame();
            }
            else
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("The game has ended.  Would you like to try again?  Y/N");
            choice = Console.ReadLine().ToLower();
            {
                switch (choice)
                {

                    case ("y"):
                        StartGame();
                        break;
                    case ("n"):
                        Console.WriteLine("Thanks for playing...");
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        EndGame();
                        break;
                }
            }
        }
    }//class
}//namespace