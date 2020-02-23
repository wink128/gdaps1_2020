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

                while (!success || grades[i] < 0 || grades[i] > 100)
                {
                    Console.Write("Invalid. Enter a positive number between 0 and 100: ");
                    success = double.TryParse(Console.ReadLine().Trim(), out grades[i]);
                }
            }

            // Grade report
            double total = 0;
            Console.WriteLine();
            Console.WriteLine("Grade Report:");
            for (int i = 0; i < numAssignments; i++)
            {
                Console.WriteLine("\t {0}: {1}", assignments[i], grades[i]);
                total += grades[i];
            }

            Console.WriteLine("-----------------------");

            // average calculations + display
            double average = total / numAssignments;
            Console.WriteLine("Final Average: {0}", average);
            Console.WriteLine();

            // grade replacement index loop
            int gradeIndex = 0;
            Console.Write("What is the index of the grade to replace? ");
            success = int.TryParse(Console.ReadLine().Trim(), out gradeIndex);
            Console.WriteLine();

            while (!success || gradeIndex < 0 || gradeIndex > numAssignments-1)
            {
                Console.WriteLine("Index must be a number between 0 and {0}", numAssignments-1);
                Console.Write("What is the index of the grade to replace? ");
                success = int.TryParse(Console.ReadLine().Trim(), out gradeIndex);
                Console.WriteLine();
            }

            // grade validation loop
            Console.Write("What is the new grade? ");
            success = double.TryParse(Console.ReadLine().Trim(), out grades[gradeIndex]);

            while (!success || grades[gradeIndex] < 0 || grades[gradeIndex] > 100)
            {
                Console.Write("Grade must be between 0 and 100. Enter a new grade: ");
                success = double.TryParse(Console.ReadLine().Trim(), out grades[gradeIndex]);
            }

            // New grade report
            total = 0;
            Console.WriteLine();
            Console.WriteLine("Grade Report:");
            for (int i = 0; i < numAssignments; i++)
            {
                Console.WriteLine("\t {0}: {1}", assignments[i], grades[i]);
                total += grades[i];
            }

            Console.WriteLine("---------------------------------------");

            // final average calculations + display
            average = total / numAssignments;
            Console.WriteLine("Final Average: {0}", average);
            Console.WriteLine();
        }
    }
}
