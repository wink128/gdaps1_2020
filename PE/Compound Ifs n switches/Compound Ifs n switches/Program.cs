using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Ifs_n_switches
{
    class Program
    {
        // Cie Thompson
        // 2/5/20
        // Compound if's and switch statements PE

        static void Main(string[] args)
        {
            string input;
            string choice;
            

            do
            {
                Console.Write("Enter a card number (2-10, Jack, King, Queen, or Ace): ");
                input = Console.ReadLine().Trim().ToLower();
                int number; // actual card number
                
                string capital;
                string leftoverLetters;
                string facecard = "";

                // this will change all card numbers into ints.
                switch (input)
                {
                    case "jack":
                        number = 11;
                        capital = input.Substring(0, 1).ToUpper();
                        leftoverLetters = input.Substring(1, input.Length - 1);
                        facecard = capital + leftoverLetters;
                        break;

                    case "king":
                        number = 12; 
                        capital = input.Substring(0, 1).ToUpper();
                        leftoverLetters = input.Substring(1, input.Length - 1);
                        facecard = capital + leftoverLetters;
                        break;

                    case "queen":
                        number = 13;
                        capital = input.Substring(0, 1).ToUpper();
                        leftoverLetters = input.Substring(1, input.Length - 1);
                        facecard = capital + leftoverLetters;
                        break;

                    case "ace":
                        number = 14;
                        capital = input.Substring(0, 1).ToUpper();
                        leftoverLetters = input.Substring(1, input.Length - 1);
                        facecard = capital + leftoverLetters;
                        break;

                    default:
                        number = int.Parse(input);
                        break;
                }

                Console.Write("Enter a card suit (Hearts, Diamonds, Clubs, Spades): ");
                input = Console.ReadLine().Trim().ToLower();
                capital = input.Substring(0, 1).ToUpper();
                leftoverLetters = input.Substring(1, input.Length - 1);
                string suit = capital + leftoverLetters;
                
                // valid or invalid number
                if (number >= 2 && number <= 10)
                {
                    Console.WriteLine("The card number {0} is valid", number);
                }
                else if (number > 10 && number < 15)
                {
                    Console.WriteLine("The card number {0} is valid", facecard);
                }
                else
                {
                    Console.WriteLine("The card number {0} is invalid", number);
                }
                
                // Valid or invalid
                if (input == "heart" || input == "diamonds" || input == "clubs" || input == "spades")
                {
                    Console.WriteLine("The card suit {0} is valid", suit);
                }
                else
                {
                    Console.WriteLine("The card suit {0} is invalid", suit);
                }

                Console.WriteLine();

                // to loop and break out of the loop
                Console.Write("Another card? (Y/N): ");
                choice = Console.ReadLine().Trim().ToUpper();

                if (choice == "Y")
                {
                    Console.WriteLine();
                }
                else if (choice == "N")
                {
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.\n");
                    Console.Write("Another card? (Y/N): ");
                    choice = Console.ReadLine().Trim().ToUpper();
                }

            } while (choice == "Y");

            // for debug
            Console.ReadLine();
        }
    }
}
