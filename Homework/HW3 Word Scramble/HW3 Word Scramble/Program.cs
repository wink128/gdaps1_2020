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
            // rng
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

            // variables that need to be there before a new game starts
            int wordsCorrect = 0;
            int score = 0;
            string guess = null;
            string game = null;

            // Intro/game loop
            Console.WriteLine("Welcome to the Word Jumble game!\n");
            Console.Write("Would you like to play? (yes/no) ");
            game = Console.ReadLine().Trim().ToLower().Substring(0,1);
            Console.WriteLine();
            
            while (game != "n" && game != "y")
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Would you like to play? (yes/no) ");
                game = Console.ReadLine().Trim().ToLower().Substring(0,1);
                Console.WriteLine();
            }            

            while (game != "n") 
            {
                // variables that can change with each iteration of the game
                int randomNum = rng.Next(10);
                int randomWordLength = wordBank[randomNum].Length;
                int numGuesses = 1;
                char[] jumbledWord = new char[randomWordLength];


                // word scrambling
                for (int i = 0; i < wordBank[randomNum].Length; i++)
                {
                    int randomLetterIndex = rng.Next(0, wordBank[randomNum].Length);
                    // pick a letter from the word
                    // the letters of the scrambled word are the letters saved  
                    // in the indices of the root word (in order)

                    
                    // save whatever letter is at said index (if the spot is empty)
                    if (jumbledWord[randomLetterIndex] == 0)
                    {
                        jumbledWord[randomLetterIndex] = wordBank[randomNum].ElementAt<char>(i);
                    }
                    
                    // don't increment if there's already a letter there
                    else if (jumbledWord[randomLetterIndex] != 0)
                    {
                        randomLetterIndex = rng.Next(0, randomWordLength);
                        i--;
                    }
                }

                Console.Write("You have 3 guesses!\nYour word is: ");
                for (int i = 0; i < randomWordLength; i++)
                {
                    Console.Write(jumbledWord[i]);
                }
                Console.WriteLine();

                // win/loss loop
                while (numGuesses<=3)
                {
                    Console.Write("\tGuess {0}: ", numGuesses);
                    guess = Console.ReadLine().Trim().ToLower();

                    if (guess == wordBank[randomNum])
                    {
                        Console.WriteLine("\tCorrect!");
                        wordsCorrect++;
                        score += randomWordLength;
                        Console.WriteLine("You have won {0} times and your score is {1}.", wordsCorrect, score);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\tIncorrect.");
                        numGuesses++;
                    }
                }

                if (numGuesses > 3 && guess != wordBank[randomNum])
                {
                    Console.WriteLine("The word was {0}. Better luck next time!", wordBank[randomNum].ToUpper());
                }

                // Play again?
                Console.WriteLine();
                Console.Write("Would you like to play again? (yes/no) ");
                game = Console.ReadLine().Trim().ToLower().Substring(0,1);
                Console.WriteLine();

                while (game != "n" && game != "y")
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write("Would you like to play? (yes/no) ");
                    game = Console.ReadLine().Trim().ToLower().Substring(0,1);
                    Console.WriteLine();
                }

                if (game == "y")
                {
                    continue;
                }

            }
            
            if (game == "n")
            {
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine();
            }

            // for debug
            Console.ReadLine();
            
        }
    }
}
