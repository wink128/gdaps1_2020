using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Math_n_Documentation
{
    class Program
    {
        // Cie Thompson
        // 1/27/20
        // Casting Math and Documentation PE using LOOPS/IF STATEMENTS!
        // It is now the If Statements PE

        static void Main(string[] args)
        {
            string choice;

            do
            {
                Console.WriteLine("Calculator Menu:\n");
                Console.WriteLine("\'addition\'\t\'division\'\t\'absolute value\'\n" +
                    "\'sine\'\t\t\'tax\'\t\t\'rounding\'\n\'comparison\'\t\'quit\'");
                Console.WriteLine();
                Console.Write("Your Choice: ");
                choice = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                switch (choice)
                {
                    case "addition":

                        // Addition
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("ADDITION");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter a floating-point number: ");
                        double num1 = double.Parse(Console.ReadLine());
                        int castedInt1 = (int)num1;
                        Console.Write("Enter another floating-point number: ");
                        double num2 = double.Parse(Console.ReadLine());
                        int castedInt2 = (int)num2;
                        int sum = castedInt1 + castedInt2;
                        Console.WriteLine("Let's add the whole number portions. " +
                            "{0} + {1} = {2}", castedInt1, castedInt2, sum);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "division":

                        // Division & Mod
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("DIVISION and MODULUS");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter a value between 1 and 100: ");
                        int num3 = int.Parse(Console.ReadLine());
                        int dividedBy10 = num3 / 10;
                        int remainder = num3 % 10;
                        Console.WriteLine("{0} divided by 10 is {1} with a remainder" +
                            " of {2}.", num3, dividedBy10, remainder);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "sine":

                        // Sine
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("SINE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter an angle in radians: ");
                        double radians = double.Parse(Console.ReadLine());
                        double sine = Math.Sin(radians);
                        Console.WriteLine("The sine of {0} is {1}.", radians, sine);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "absolute value":

                        // Abs Val
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("ABSOLUTE VALUE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter a negative value: ");
                        int num4 = int.Parse(Console.ReadLine());
                        int absVal = Math.Abs(num4);
                        Console.WriteLine("The absolute value of {0} is {1}.",
                            num4, absVal);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "tax":

                        // Taxes
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("TAX CALCULATION");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter a price between $0 and $10): ");
                        double price = double.Parse(Console.ReadLine());
                        double tax = (price * .08);
                        double priceAfterTax = price + tax;
                        int dollarPortion = (int)priceAfterTax;
                        double centPortion = (priceAfterTax - dollarPortion);
                        Console.WriteLine("${0} with NY sales tax applied is ${1:F2}.",
                            price, priceAfterTax);
                        Console.WriteLine("The dollar portion is {0}.", dollarPortion);
                        Console.WriteLine("The cent portion is {0:F2}.", centPortion);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "rounding":

                        // Rounding
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("ROUNDING");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter a floating-point number: ");
                        double num5 = double.Parse(Console.ReadLine());
                        double rounded = Math.Round(num5);
                        Console.WriteLine("{0} rounds to {1}", num5, rounded);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "comparison":

                        // Comparison
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("COMPARISON");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Enter any number: ");
                        double num6 = double.Parse(Console.ReadLine());
                        Console.Write("Enter another number: ");
                        double num7 = double.Parse(Console.ReadLine());
                        double comparison = Math.Max(num6, num7);
                        Console.WriteLine("{0} is the larger value.", comparison);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                    case "quit":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Goodbye!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Invalid Input");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;

                }
            
            } while (choice != "quit");

            // For Debug
            Console.ReadLine();
        }
    }
}
