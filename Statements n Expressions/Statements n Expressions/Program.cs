using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements_n_Expressions
{
    class Program
    {
        // Cie Thompson
        // Class: Program
        // Purpose: To hold my main method
        // Restrictions: none 

        static void Main(string[] args)
        {
            // character name
            Console.WriteLine("Name: Tony Stark");
            Console.WriteLine();

            // stat 1: intelligence
            Console.WriteLine((50*.2) + " Intelligence");

            // stat 2: emotional stability
            Console.WriteLine(((50*.2)/2) + " Emotional Stability");

            // stat 3: Compassion
            Console.WriteLine(7 + " Compassion");

            // stat 4: Stubbornness
            Console.WriteLine(((((50 * .2) / 2) + 7 )-2) + " Stubbornness");

            // stat 5: Sarcasm
            Console.WriteLine((50 - ((50 * .2) +
                ((50 * .2) / 2) + 7 + 
                (((50 * .2) / 2) + 7) - 2)) + " Sarcasm");

            // total
            Console.WriteLine();
            Console.WriteLine("TOTAL: 50");

            // for debug mode
            Console.ReadLine();
        }
    }
}
