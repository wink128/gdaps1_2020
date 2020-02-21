using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        // Cie Thompson
        // 2/19/20
        // Number Guessing Game PE

        static void Main(string[] args)
        {
            // Create Random object (0-100)
            // print out random number (for testing purposes)
            // Counter for turn while asking for input each turn
            // used turn vs invalid input
            // win/loss conditions (8 turns or 1 correct guess + num of turns used)

            // rand obj
            Random rng = new Random();

            // Correct number
            int correct = rng.Next(0, 101);
            Console.WriteLine(correct);
            Console.WriteLine();

            // Turn Counter + guess variable
            int count = 1;
            int guess;

            // Guessing loop
            do
            {
                Console.Write("Turn #{0}: Enter your guess: ", count);

                // Tryparse
                bool success = int.TryParse(Console.ReadLine().Trim(), out guess);

                // validation loop
                while (!success || guess < 0 || guess > 100)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.WriteLine();
                    Console.Write("Turn #{0}: Enter your guess: ", count);
                    success = int.TryParse(Console.ReadLine().Trim(), out guess);
                }

                // win/loss conditions
                if (guess < correct && guess > 0)
                {
                    Console.WriteLine("Too low");
                    Console.WriteLine();
                    count++;
                }
                else if (guess > correct && guess < 100)
                {
                    Console.WriteLine("Too high");
                    Console.WriteLine();
                    count++;
                }
                else if (guess == correct)
                {
                    break;
                }

            } while (count<=8);

            // actual win/loss dialogue
            if (guess==correct)
            {
                Console.WriteLine("Correct! You won in {0} turns!", count);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You ran out of turns. The correct answer was {0}.", correct);
                Console.WriteLine();
            }
        }
    }
}
