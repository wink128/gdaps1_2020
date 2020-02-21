using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Golf
{
    class Program
    {
        // Cie Thompson
        // 2/20/20
        // Golf HW

        static void Main(string[] args)
        {
            // introduction
            Console.WriteLine("Welcome to Artillery Golf!");
            Console.WriteLine("Your goal is to hit a target 751 meters away.");
            Console.WriteLine();


            // target prompt
            // velocity > 0
            // 0 < angle < 90
            int attempt = 1;

            while (attempt <= 10)
            {


                Console.WriteLine("Attempt {0} ----------------------------------", attempt);

                // angle loop
                double angle;
                bool success;
                Console.Write("Enter the cannon's angle (between 0 and 90 degrees): ");
                success = double.TryParse(Console.ReadLine(), out angle);
                while (!success || angle < 0 || angle > 90)
                {
                    Console.WriteLine("That is an invalid angle.");
                    Console.Write("Enter the cannon's angle (between 0 and 90 degrees): ");
                    success = double.TryParse(Console.ReadLine(), out angle);
                }

                // velocity loop
                double velocity = 0;
                Console.Write("Enter the cannonball's initial velocity (a positive number): ");
                success = double.TryParse(Console.ReadLine(), out velocity);
                while (!success || velocity < 0)
                {
                    Console.WriteLine("That is an invalid velocity.");
                    Console.Write("Enter the cannonball's initial velocity (a positive number): ");
                    success = double.TryParse(Console.ReadLine(), out velocity);
                }

                // calculations
                double radians = ((angle * Math.PI) / 180);
                double t = (velocity * Math.Sin(radians) + Math.Pow(Math.Pow(velocity, 2.0) *
                    Math.Pow(Math.Sin(radians), 2.0) + 20.0 * 2.0 * Math.Sin(radians), 0.5)) / 10;
                double distanceTraveled = velocity * Math.Cos(radians) * t;
                double distanceAway = 751 - distanceTraveled;

                // attempt summary
                Console.WriteLine();
                Console.WriteLine("Thank you.");
                Console.WriteLine();
                Console.WriteLine("A cannonball fired with an initial velocity of " + velocity +
                    " m/s, at an angle\nof " + angle + " degrees from the ground, will strike " +
                    "the ground\n" + distanceTraveled + " meters away.");
                Console.WriteLine();

                // win/fail conditions
                if (distanceAway > 1 || distanceAway < -1)
                {
                    Console.WriteLine("You are " + Math.Abs(distanceAway) + " meters from the target. Try again!");
                    Console.WriteLine();
                    attempt++;
                }
                else if (distanceAway < 1 && distanceAway > -1)
                {
                    Console.WriteLine("You are " + Math.Abs(distanceAway) + " meters from the target. Success!");
                    Console.WriteLine();
                    break;
                }
            }

            if (attempt > 10)
            {
                Console.WriteLine("Out of attempts. Thank you for playing.");
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
