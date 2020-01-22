using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration/initialization
            string playerName = "Alex";
            int startingResources = 100;
            int currentResources= 100;
            int shipPrice = 70;
            int weaponUpgrade = 16;
            const int AmountEarnedPerKill = 5;
            const int MissileCost = 4;

            // introduction
            Console.WriteLine("{0} is starting the game with {1} resources.",
                playerName, startingResources);
            Console.WriteLine(">> Current Resources: {0}", currentResources);

            // new ship + weapon upgrade calculation
            Console.WriteLine("{0} purchased a ship for {1} resources",
                shipPrice, weaponUpgrade);
            Console.WriteLine(">> Current Resources: {0}", currentResources);

            // for debug
            Console.ReadLine();

        }
    }
}
