using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Formatting
{
    class Program
    {
        // Cie Thompson
        // 1/29/20
        // String Formatting PE

        static void Main(string[] args)
        {
            /*
            // Name Analysis
            Console.Write("I'd like to analyze your first name. What is it? ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string name = Console.ReadLine();
            string nameUpper = name.ToUpper();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Thanks {0}", nameUpper);
            string nameLower = name.ToLower();
            Console.WriteLine("Your name is also {0}", nameLower);
            Console.WriteLine("It has {0} letters.", name.Length);
            Console.WriteLine("The first letter of your name is {0}",
                name.Substring(0, 1));
            Console.WriteLine("The last letter of your name is {0}",
                name.Substring((name.Length)-1,name.Length));
            Console.WriteLine();
            */
            // ToString()
            Console.Write("Enter a number with a decimal value: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            double decimalValue = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nHere are your results using the ToString() method:");
            Console.WriteLine("{0}\n{1}\n{2}\n", 
                decimalValue.ToString("F2"),
                decimalValue.ToString("P4"),
                decimalValue.ToString("F0"));

            // String.Format()
            Console.WriteLine("Here are your results using the String.Format() method:");
            string newString = String.Format("{0:F2}\n{1:P4}\n{2:F0}\n",
                decimalValue, decimalValue, decimalValue);
            Console.WriteLine(newString);

            // Console.WriteLine()
            Console.WriteLine("Here are your results using the Console.WriteLine() method:");
            Console.WriteLine("{0:F2}\n{1:P4}\n{2:F0}\n", decimalValue, decimalValue, decimalValue);
        }
    }
}
