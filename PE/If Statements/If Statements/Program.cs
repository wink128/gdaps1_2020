using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        // Cie Thompson
        // 2/3/19
        // If Statements PE

        static void Main(string[] args)
        {
            string sight;
            do
            {
                Console.WriteLine("Character: Creeper (aww man)");
                Console.WriteLine("Your choices are: a PLAYER, a FRIENDLY mob," +
                    " a HOSTILE mob, or NOTHING\n");
                Console.Write("Creeper, what do you see? ");
                Console.ForegroundColor = ConsoleColor.Green;
                sight = Console.ReadLine().Trim().ToUpper();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();

                if (sight == "PLAYER")
                {
                    Console.Write("How many blocks away are they? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    int distance = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();

                    if (distance <= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Explode.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Follow them.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                    }
                }
                else if (sight == "FRIENDLY")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try to turn them to the dark side.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
                else if (sight == "HOSTILE")
                {
                    Console.WriteLine("Go make friends!");
                    Console.WriteLine();
                }
                else if (sight == "HEROBRINE")
                {
                    Console.WriteLine("*GASP* HE LIVES");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("YOu'Re hAcKinG");
                    Console.WriteLine();
                }
            } while (sight != "NOTHING");
        }
    }
}
