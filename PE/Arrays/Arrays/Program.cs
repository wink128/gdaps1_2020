using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        // Cie Thompson
        // 2/23/20
        // Arrays PE

        static void Main(string[] args)
        {
            // introduction and validation
            Console.WriteLine("Welcome to the Gradebook.");
            Console.Write("How many assignments have you had? ");
            int numAssignments = 0;
            bool success = int.TryParse(Console.ReadLine().Trim(), out numAssignments);

            while (!success || numAssignments <= 0)
            {
                Console.Write("Invalid. Enter a positive number: ");
                success = int.TryParse(Console.ReadLine().Trim(), out numAssignments);
            }

            // assignment array
            string[] assignments = new string[numAssignments];

            // grade array
            double[] grades = new double[numAssignments];

            // assignment + grade loop
            for (int i = 0; i < numAssignments; i++)
            {
                Console.WriteLine();
                Console.Write("Enter assignment name: ");
                assignments[i] = Console.ReadLine().Trim();

                // grade validation
                Console.Write("Enter grade: ");
                success = double.TryParse(Console.ReadLine().Trim(), out grades[i]);

                while (!success || grades[i] < 0)
                {
                    Console.Write("Invalid. Enter a positive number: ");
                    success = double.TryParse(Console.ReadLine().Trim(), out grades[i]);
                }
            }

            // Grade report
            Console.WriteLine();
            Console.WriteLine("Grade Report:");
            for (int i = 0; i < numAssignments; i++)
            {
                Console.WriteLine("\t {0}: {1}", assignments[i], grades[i]);
            }

            Console.WriteLine("--------------------------------------");

            // final average calculations + display
            Console.WriteLine("Final average: ");

        }
    }
}
