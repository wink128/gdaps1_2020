using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Word_Scramble
{
    class Program
    {
        // Cie Thompson
        // 2/24/20
        // Hw 3 Word Scramble

        static void Main(string[] args)
        {
            // RNG
            Random rng = new Random();

            // 10 words (various pokemon)
            string[] wordBank = new string[10];
            wordBank[0] = "slugma";
            wordBank[1] = "gulpin";
            wordBank[2] = "mimikyu";
            wordBank[3] = "pikachu";
            wordBank[4] = "togepi";
            wordBank[5] = "snorlax";
            wordBank[6] = "magikarp";
            wordBank[7] = "goldeen";
            wordBank[8] = "clefairy";
            wordBank[9] = "lapras";

            // variables
            int wordsCorrect = 0;
            int score = 0;
            string game = null;

            // Intro/game loop ligma
            Console.WriteLine("Welcome to the Word Jumble game!\n");
            Console.Write("Would you like to play? (yes/no) ");
            game = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();
            
            while (game != "no" && game != "yes")
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Would you like to play? (yes/no) ");
                game = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();
            }            

            while (game != "no") 
            {
                int randomWord = rng.Next(0, 10);
                char[] jumbledWord = new char[randomWord];

                // jumble
                for (int i = 0; i < randomWord; i++)
                {
                    jumbledWord[i]=help
                }
                
                // Play again?
                Console.Write("Would you like to play again? ");
                game = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                while (game != "no" && game != "yes")
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write("Would you like to play? (yes/no) ");
                    game = Console.ReadLine().Trim().ToLower();
                    Console.WriteLine();
                }

                if (game == "yes")
                {
                    continue;
                }

            }
            
            if (game == "no")
            {
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine();
            }
            
        }
    }
}
