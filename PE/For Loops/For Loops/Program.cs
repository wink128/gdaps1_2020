using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        // Cie Thompson
        // 2/12/20
        // For Loops PE

        static void Main(string[] args)
        {
            int counter=0;

            // While loop
            Console.WriteLine("While:");
            while (counter <= 10)
            {
                Console.Write(counter + " ");
                counter++;
            }

            Console.WriteLine("\n");
            counter = 0;

            // Do-While
            Console.WriteLine("Do-While:");
            do
            {
                Console.Write(counter + " ");
                counter++;
            } while (counter<= 10);

            Console.WriteLine("\n");

            // For
            Console.WriteLine("For:");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            // For
            Console.WriteLine("For:");
            for (int i = 100; i >= 90; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            // For
            Console.WriteLine("For:");
            for (int i = 0; i <= 50; i+=5)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            // dimension prompt + validation
            Console.Write("Enter a width: ");
            int width = int.Parse(Console.ReadLine());

            while (width < 0)
            {
                Console.Write("Number must be positive. Try again: ");
                width = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a height: ");
            int height = int.Parse(Console.ReadLine());

            while (height < 0)
            {
                Console.Write("Number must be positive. Try again: ");
                height = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // --- ASCII ---

            // Full box
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("o");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            
            // Hollow box
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    
                    if (j==0 || j == width || i==0 || i == height-2)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            
        }
    }
}
