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
            // introduction
            Console.WriteLine("Welcome to the Superman Jump simulator!\n");
            Console.WriteLine("Your target building height is 660 feet.\n");
            Console.WriteLine("Please enter the gravitational constant for the " +
                "planet on which Superman is\ncurrently attempting this jump. " +
                "The units are in ft/s^2\n");
            Console.WriteLine();

            double constant;
            bool success;

            // guess validation
            Console.Write("Gravitational Constant: ");
            success = double.TryParse(Console.ReadLine().Trim(), out constant);
            Console.WriteLine();

            while (!success || constant < 0)
            {
                Console.WriteLine("Invalid value. Enter a positive number.\n");
                Console.Write("Gravitational Constant: ");
                success = double.TryParse(Console.ReadLine().Trim(), out constant);
                Console.WriteLine();
            }

            // Calculations

            // another value?


        }
    }
}
