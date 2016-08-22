using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public string Name;

        public Player()//constructor
        {
            Name = GetUserInfo();
        }
        public string GetUserInfo()
        {

            Console.Write("\nWhat's your name?   ");
            Name = Console.ReadLine();
            return Name;
        }
    }//class
}//namespace
