using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Superman
{
    class Program
    {
        // Cie Thompson
        // 2/20/20
        // Superman HW

        static void Main(string[] args)
        {
            string playAgain = null;
            while (playAgain != "N")
            {

                // introduction
                Console.WriteLine("Welcome to the Superman Jump simulator!\n");
                Console.WriteLine("Your target building height is 660 feet.\n");
                Console.WriteLine("Please enter the gravitational constant for the " +
                    "planet on which Superman is\ncurrently attempting this jump. " +
                    "The units are in ft/s^2\n");

                double gravConst = 0;
                bool success;

                // guess validation
                Console.Write("Gravitational Constant: ");
                success = double.TryParse(Console.ReadLine().Trim(), out gravConst);
                Console.WriteLine();

                while (!success || gravConst < 0)
                {
                    Console.WriteLine("Invalid value. Enter a positive number.\n");
                    Console.Write("Gravitational Constant: ");
                    success = double.TryParse(Console.ReadLine().Trim(), out gravConst);
                    Console.WriteLine();
                }

                // Calculations + display
                double initialVelocity = Math.Sqrt(2 * gravConst * 660);
                Console.WriteLine("Superman must jump with an initial velocity of at least {0} ft/s.",
                    initialVelocity);
                Console.WriteLine();

                // another value?
                Console.Write("Would you like to play again? (Y/N): ");
                playAgain = Console.ReadLine().Trim().ToUpper();
                
                while (playAgain != "Y" && playAgain != "N")
                {
                    Console.WriteLine("Invalid value.");
                    Console.Write("Would you like to play again? (Y/N): ");
                    playAgain = Console.ReadLine().Trim().ToUpper();
                }

                if (playAgain == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine();
                    break;
                }
                else if (playAgain == "Y")
                {
                    Console.WriteLine();
                    continue;
                }

            }
        }
    }
}
