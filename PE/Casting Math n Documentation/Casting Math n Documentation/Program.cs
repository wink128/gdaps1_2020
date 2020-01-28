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
        // Casting Math and Documentation PE

        static void Main(string[] args)
        {
            // Addition
            Console.WriteLine("ADDITION");
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

            // Division & Mod
            Console.WriteLine("DIVISION and MODULUS");
            Console.Write("Enter a value between 1 and 100: ");
            int num3 = int.Parse(Console.ReadLine());
            int dividedBy10 = num3 / 10;
            int remainder = num3 % 10;
            Console.WriteLine("{0} divided by 10 is {1} with a remainder" +
                " of {2}.", num3, dividedBy10, remainder);
            Console.WriteLine();

            // Sine
            Console.WriteLine("SINE");
            Console.Write("Enter an angle in radians: ");
            double radians = double.Parse(Console.ReadLine());
            double sine = Math.Sin(radians);
            Console.WriteLine("The sine of {0} is {1}.", radians, sine);
            Console.WriteLine();

            // Abs Val
            Console.WriteLine("ABSOLUTE VALUE");
            Console.Write("Enter a negative value: ");
            int num4 = int.Parse(Console.ReadLine());
            int absVal = Math.Abs(num4);
            Console.WriteLine("The absolute value of {0} is {1}.",
                num4, absVal);
            Console.WriteLine();

            // Taxes
            Console.WriteLine("TAX CALCULATION");
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
            
            // Rounding
            Console.WriteLine("ROUNDING");
            Console.Write("Enter a floating-point number: ");
            double num5 = double.Parse(Console.ReadLine());
            double rounded = Math.Round(num5);
            Console.WriteLine("{0} rounds to {1}", num5, rounded);
            Console.WriteLine();

            // Comparison
            Console.WriteLine("COMPARISON");
            Console.Write("Enter any number: ");
            double num6 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num7 = double.Parse(Console.ReadLine());
            double comparison = Math.Max(num6, num7);
            Console.WriteLine("{0} is the larger value.", comparison);
            Console.WriteLine();

            // For Debug
            Console.ReadLine();
        }
    }
}
