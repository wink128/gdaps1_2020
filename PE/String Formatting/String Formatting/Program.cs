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



        }
    }
}
