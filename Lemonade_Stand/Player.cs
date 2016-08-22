using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public string Name1;

        public Player()//constructor
        {
            Name1 = GetUserInfo();
        }

        public string GetUserInfo()
        {

            Console.Write("\nWhat's your name?   ");
            Name1 = Console.ReadLine();
            return Name1;
        }

    }//class
}//namespace
