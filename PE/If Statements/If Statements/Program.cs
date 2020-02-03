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
                sight = Console.ReadLine().Trim().ToUpper();

                if (sight == "PLAYER")
                {
                    Console.Write("How far away are they? ");
                    int distance = int.Parse(Console.ReadLine());

                    if (distance <= 3)
                    {
                        Console.WriteLine("Explode.");
                    }
                    else
                    {
                        Console.WriteLine("Follow them.");
                    }
                }
                else if (sight == "FRIENDLY")
                {
                    Console.WriteLine("Try to turn them to the dark side.");
                }
                else if (sight == "HOSTILE")
                {
                    Console.WriteLine("Go make friends!");
                }
                else if (sight == "HEROBRINE")
                {
                    Console.WriteLine("*GASP* HE LIVES");
                }
                else
                {
                    Console.WriteLine("Despawn.");
                    break;
                }
            } while (sight != "NOTHING");
        }
    }
}
