using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        // Cie Thompson
        // 1/24/20
        // Variables PE

        static void Main(string[] args)
        {
            // variable declaration/initialization
            string playerName = "Alex";
            const int startingResources = 100;
            int currentResources= 100;
            const int shipPrice = 70;
            const int weaponUpgrade = 16;
            const int AmountEarnedPerKill = 5;
            const int MissileCost = 4;

            // introduction
            Console.WriteLine("{0} is starting the game with {1} resources.",
                playerName, startingResources);
            Console.WriteLine(">> Current Resources: {0}", currentResources);
            Console.WriteLine();

            // new ship + weapon upgrade calculation
            Console.WriteLine("{0} purchased a ship for {1} resources",
                playerName, shipPrice);
            currentResources-=shipPrice;
            Console.WriteLine("{0} purchased a weapons upgrade for {1} resources",
                playerName, weaponUpgrade);
            currentResources-=weaponUpgrade;

            Console.WriteLine(">> Current Resources: {0}", currentResources);
            Console.WriteLine();

            // missile purchase
            Console.WriteLine("{0} can purchase 3 missiles with their remaining"+
                " resources, so they did.", playerName);
            currentResources-=(MissileCost*3);
            Console.WriteLine(">> Current Resources: {0}", currentResources);
            Console.WriteLine();

            // alien kills
            Console.WriteLine("{0} killed 7 aliens, earning 35 resources.", 
                playerName);
            currentResources+=(AmountEarnedPerKill*7);
            Console.WriteLine(">> Current Resources: {0}", currentResources);
            Console.WriteLine();

            // selling and stealing gear
            Console.WriteLine("{0} stole and sold gear for 112 resources.", 
                playerName);
            currentResources+=112;
            Console.WriteLine(">> Current Resources: {0}", currentResources);
            Console.WriteLine();

            // hangar space leasing
            Console.WriteLine("{0} leased a hangar space for a month for "+
                "20 resources.", playerName);
            currentResources-=20;
            Console.WriteLine(">> Current Resources: {0}", currentResources);
            Console.WriteLine();

            // for debug
            Console.ReadLine();

        }
    }
}
