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
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Character: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Creeper ");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                // sorry I had to do it for the meme
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("(");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("a");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("w");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("w ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("m");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("a");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(")");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Your choices are: a PLAYER, a FRIENDLY mob," +
                    " a HOSTILE mob, HEROBRINE, or NOTHING\n");
                Console.Write("Creeper, what do you see? ");
                Console.ForegroundColor = ConsoleColor.Green;
                sight = Console.ReadLine().Trim().ToUpper();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();

                if (sight == "PLAYER")
                {
                    Console.Write("How many blocks away are they? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    int distance = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();

                    if (distance <= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Explode.");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                    }
                    else if (distance > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Follow them.");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("???");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        Console.Write("How many blocks away are they? ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        distance = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }
                }
                else if (sight == "FRIENDLY")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try to turn them to the dark side.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                }
                else if (sight == "HOSTILE")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Go make friends!");
                    Console.WriteLine();
                }
                else if (sight == "HEROBRINE")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*GASP* HE LIVES");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                }
                else if (sight == "NOTHING")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Despawn.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                    break;
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
