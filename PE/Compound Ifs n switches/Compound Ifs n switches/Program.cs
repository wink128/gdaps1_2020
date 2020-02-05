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
            string facecard;

            do
            {
                Console.Write("Enter a card number (2-10, Jack, King, Queen, or Ace): ");
                input = Console.ReadLine().Trim().ToLower();
                int number; // actual card number
                
                string capital;
                string leftoverLetters;

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

                // valid or invalid
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("The card number {0} is valid", number);
                        break;

                    case 11:
                    case 12:
                    case 13:
                    case 14:
                        Console.WriteLine("The card number {0} is valid", facecard);
                        break;
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
                    break;
                }

            } while (choice == "Y");
        }
    }
}
