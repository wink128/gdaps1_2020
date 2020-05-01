using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThompsonCieHW14
{
    class TextAnalyze
    {
        // attributes
        string[] alphabet = new string[26] { "a", "b", "c", "d", "e", "f", "g",
                                             "h", "i", "j", "k", "l", "m", "n",
                                             "o", "p", "q", "r", "s", "t", "u",
                                             "v", "w", "x", "y", "z" };

        static List<int> numberLetters = new List<int>();
        static string[] phrase = new string[1];
        User myUser = new User();

        // property
        static string[] Phrase
        {
            get { return phrase; }
            set
            {
                if (phrase == null)
                {
                    while (phrase[1] == null)
                    {
                        Console.Write("Enter a phrase: ");
                        phrase[1] = Console.ReadLine();
                    }
                    
                }
                else phrase = value;
            }
        }

        // methods
        /// <summary>
        /// Stores username as a variable and tells user what program does
        /// </summary>
        /// <returns></returns>
        static public string Welcome()
        {
            Console.Write("Nice to meet you! What is your name? ");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("My goal in this program is to count the letters in a phrase.");
            
            return name;
        }

        /// <summary>
        /// reads text from command line
        /// </summary>
        static public void ReadText()
        {
            Console.Write("Please enter a phrase: ");
            phrase[0] = Console.ReadLine().Trim();
        }

        /// <summary>
        /// Reads text from file
        /// </summary>
        static public void ReadText(string filename)
        {
            StreamReader myReader = new StreamReader(filename);

            // read data

            myReader.Close();
        }

        /// <summary>
        /// Counts number of letters in phrase
        /// </summary>
        /// <returns></returns>
        static public void Counter()
        {
            int counter = 0;
            // count letters in phrase
            // loop to get each letter
            for (int i = 0; i < phrase.Length; i++)
            {
                // go through the phrase for each letter in the alphabet
                // if letters occur add that to the num letter list

                // counter goes up (or stays at 0) and add it to the count list

                

                string letter = phrase.ElementAt<string>(i);
                switch (letter)
                {
                    case "a":
                        // add to the count because it appeared
                        counter++;
                        // add the counnt to the proper spot in the list
                        numberLetters[0] = counter;
                        break;
                    case "b":
                        counter++;
                        numberLetters[1] = counter;
                        break;
                    case "c":
                        counter++;
                        numberLetters[2] = counter;
                        break;
                    case "d":
                        counter++;
                        numberLetters[3] = counter;
                        break;
                    case "e":
                        counter++;
                        numberLetters[4] = counter;
                        break;
                    case "f":
                        counter++;
                        numberLetters[5] = counter;
                        break;
                    case "g":
                        counter++;
                        numberLetters[6] = counter;
                        break;
                    case "h":
                        counter++;
                        numberLetters[7] = counter;
                        break;
                    case "i":
                        counter++;
                        numberLetters[8] = counter;
                        break;
                    case "j":
                        counter++;
                        numberLetters[9] = counter;
                        break;
                    case "k":
                        counter++;
                        numberLetters[10] = counter;
                        break;
                    case "l":
                        counter++;
                        numberLetters[11] = counter;
                        break;
                    case "m":
                        counter++;
                        numberLetters[12] = counter;
                        break;
                    case "n":
                        counter++;
                        numberLetters[13] = counter;
                        break;
                    case "o":
                        counter++;
                        numberLetters[14] = counter;
                        break;
                    case "p":
                        counter++;
                        numberLetters[15] = counter;
                        break;
                    case "q":
                        counter++;
                        numberLetters[16] = counter;
                        break;
                    case "r":
                        counter++;
                        numberLetters[17] = counter;
                        break;
                    case "s":
                        counter++;
                        numberLetters[18] = counter;
                        break;
                    case "t":
                        counter++;
                        numberLetters[19] = counter;
                        break;
                    case "u":
                        counter++;
                        numberLetters[20] = counter;
                        break;
                    case "v":
                        counter++;
                        numberLetters[21] = counter;
                        break;
                    case "w":
                        counter++;
                        numberLetters[22] = counter;
                        break;
                    case "x":
                        counter++;
                        numberLetters[23] = counter;
                        break;
                    case "y":
                        counter++;
                        numberLetters[24] = counter;
                        break;
                    case "z":
                        counter++;
                        numberLetters[25] = counter;
                        break;
                    default:
                        break;
                }

            }

                
        }
    }
}
