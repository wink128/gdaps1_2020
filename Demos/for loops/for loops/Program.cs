using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a positive whole number: ");
            int input = int.Parse(Console.ReadLine());

            while (!(input > 0))
            {
                Console.Write("Invalid. Enter a positive whole number: ");
                input = int.Parse(Console.ReadLine());
            }

            if (input > 0)
            {
                int counter = 0;
                while (counter < input + 1)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
