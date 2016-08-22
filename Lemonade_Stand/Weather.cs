using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public int weatherNumber;
        public bool willBuy;
        public bool willApproach;
        public int potentialCustomer;
        public int approachingCustomers;
        public List<int> dailyCustomers = new List<int>();
        public List<int> customerApproaching = new List<int>();

        public Weather()//constructor
        {

        }
        public int DetermineWeather()
        {
            Random weatherRand = new Random();
            Thread.Sleep(5);
            int randomWeather = weatherRand.Next(0, 50);
            if (randomWeather >= 0 && randomWeather <= 10)
            {
                weatherNumber = 1;
            }
            else if (randomWeather >= 11 && randomWeather <= 20)
            {
                weatherNumber = 2;
            }
            else if (randomWeather >= 21 && randomWeather <= 30)
            {
                weatherNumber = 3;
            }
            else if (randomWeather >= 31 && randomWeather <= 40)
            {
                weatherNumber = 4;
            }
            else if (randomWeather >= 41 && randomWeather <= 50)
            {
                weatherNumber = 5;
            }

            return weatherNumber;
        }

        public void PresentDailyWeather()
        {
            switch (weatherNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Today's weather forecast: \nSunny and Warm!!");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Today's weather forecast:\nSunny but Cool!!");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Today's weather forecast:\nRainy and Chilly!!");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Today's weather forecast:\nShowers but Warm!!");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Today's weather forecast:\nHazy and Humid!!");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }

        public void ShowDailyWeather()
        {

            switch (weatherNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Today's weather forecast is Sunny and Warm!!");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Today's weather forecast is Sunny but Cool!!");

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Today's weather forecast is Rainy and Chilly!!");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Today's weather forecast is Showers but Warm!!");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Today's weather forecast is Hazy and Humid!!");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
        }
        public int DetermineWillBuyWeather()
        {
            customerApproaching.Clear();
            Random custApproach = new Random();
            foreach (int buyingCust in dailyCustomers)
            {
                int weatherBuy = custApproach.Next(0, 100);
                if (weatherNumber == 1)
                {
                    if (weatherBuy < 90)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weatherNumber == 2)
                {
                    if (weatherBuy < 70)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weatherNumber == 3)
                {
                    if (weatherBuy < 50)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weatherNumber == 4)
                {
                    if (weatherBuy < 60)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weatherNumber == 5)
                {
                    if (weatherBuy < 10)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }
            }

            approachingCustomers = customerApproaching.Count;
            return approachingCustomers;
        }

        public void GetNumberOfPotentialCustomers()
        {
            dailyCustomers.Clear();
            Random custNum = new Random();
            Thread.Sleep(5);
            if (weatherNumber == 1)
            {
                potentialCustomer = custNum.Next(50, 70);
            }
            else if (weatherNumber == 2)
            {
                potentialCustomer = custNum.Next(40, 50);
            }
            else if (weatherNumber == 3)
            {
                potentialCustomer = custNum.Next(20, 30);
            }
            else if (weatherNumber == 4)
            {
                potentialCustomer = custNum.Next(30, 40);
            }
            else if (weatherNumber == 5)
            {
                potentialCustomer = custNum.Next(20, 25);
            }

            for (int customers = 1; customers <= potentialCustomer; customers++)
            {
                dailyCustomers.Add(1);
            }
        }
    }//class
}//namespace
