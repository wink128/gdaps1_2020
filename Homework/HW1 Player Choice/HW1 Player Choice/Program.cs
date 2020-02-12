using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Player_Choice
{
    class Program
    {
        // Cie Thompson
        // 2/07/20
        // HW1 Player Choice
        static void Main(string[] args)
        {
            
            // variables used
            string pokemon=null;
            string bond = null; 
            int medal = 0;

            // scene 1
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("SCENE 1 - Choose a Pokemon");
            Console.WriteLine();
            Console.Write("Today's the day. Your 10th birthday. You finally get to choose your " +
                "first pokemon and\nbecome a Pokemon Trainer!\nYou excitedly make your way over to the lab.\n\n" +
                "Professor Sapling:\n\t\"Here are your two starter pokemon. They are two fan favorites!\n\t" +
                "Very popular in this region.\"\n");
            Console.WriteLine();

            // scene 1 choices
            Console.WriteLine("Would you like to choose SLUGMA " +
                "or MAGIKARP?");
            Console.WriteLine();
            Console.Write("> ");
            string choice1 = Console.ReadLine().Trim().ToUpper();

            if (!(choice1 == "SLUGMA" || choice1 == "MAGIKARP"))
            {
                Console.WriteLine("Invalid Answer");
                Console.ReadLine();
                return;
            }

            if (choice1 == "SLUGMA")
            {
                pokemon = "slugma";
                Console.WriteLine("\n\t\"Brilliant choice! My friends over in Baker Gang would be very proud!\"");
                Console.WriteLine();
            }
            else if (choice1 == "MAGIKARP")
            {
                pokemon = "magikarp";
                Console.WriteLine("\n\t\"A fine choice! This one seems to be a little scared though.\n\t" +
                    "Maybe you can find a way to cheer him up!\"");
                Console.WriteLine();
            }

            // scene 2
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("SCENE 2 - Afternoon Adventure");
            Console.WriteLine();
            Console.WriteLine("While walking with your new beloved pokemon, you both seem to be " +
                "a bit bored of walking and\ndecide to do something else.");

            // scene 2 choices
            if (choice1 == "MAGIKARP")
            {
                Console.WriteLine("What would you like to do? Take a NAP, CONTINUE on your hunt to " +
                    "catch wild pokemon until\ndark, or ENCOURAGE your gloomy magikarp by showing it " +
                    "the game Magikarp Jump?");
                Console.WriteLine();
                Console.Write("> ");
            }
            else
            {
                Console.WriteLine("What would you like to do? Take a NAP or CONTINUE on your hunt to " +
                    "catch wild pokemon until dark?");
                Console.WriteLine();
                Console.Write("> ");
            }
            string choice2 = Console.ReadLine().Trim().ToUpper();

            if (choice2 == "NAP")
            {
                Console.WriteLine("You underestimated just how tired you and your little pokemon were \n" +
                    "and you both fell asleep until the next morning.");
                Console.WriteLine();
                bond = "strong";
            }
            else if (choice2 == "CONTINUE")
            {
                Console.WriteLine("You continue on your journey until dark.");
                Console.WriteLine();
                bond = "weak";
            }
            else if (choice2 == "ENCOURAGE")
            {
                Console.WriteLine("You show your magikarp a bunch of videos of other magikarp jumping." +
                    " A nearby fisherman\nwatches intently and is so proud of your little magikarp that he " +
                    "gives it a shiny medal!\nThen you go home and get some well-deserved rest.");
                Console.WriteLine();
                medal++;

            }
            else
            {
                Console.WriteLine("Invalid answer.");
                Console.ReadLine();
            }

            // scene 3
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("SCENE 3 - A Fateful Encounter");
            Console.WriteLine();
            Console.WriteLine("The next day, while walking on your favorite path, you encounter the neighborhood bully\n" +
                "who wants to battle you with their petilil!");
            Console.WriteLine();

            if (pokemon == "slugma")
            {
                Console.WriteLine("You and your trusty slugma easily defeat the neighborhood bully's petilil with\n" +
                    "slugma's super effective flamethrower!");
                Console.WriteLine();
            }
            else if (pokemon == "magikarp" && medal==1)
            {
                Console.WriteLine("Although the type matchup wasn't the greatest, you and your precious magikarp\n" +
                    "manage to scare off the bully with magikarp's very intimidating flail. \nHe learned well from the pros.");
                Console.WriteLine();
            }
            else if (pokemon == "magikarp" && medal==0 && bond == "weak")
            {
                Console.WriteLine("Because of how tired your poor little magikarp was from adventuring last night,\n" +
                    "it's battle skills weren't the greatest and he fell asleep and lost.");
                Console.WriteLine();
            }
            else if (pokemon == "magikarp" && medal == 0 && bond == "strong")
            {
                Console.WriteLine("Because of how much your magikarp trusts you, it triedd it's very best to win and make you proud!\n" +
                    "It worked!");
                Console.WriteLine();
            }

        }
    }
}
