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

        List<int> numberLetters = new List<int>();
        string phrase;
        User myUser = new User();

        // methods
        /// <summary>
        /// Stores username as a variable and tells user what program does
        /// </summary>
        /// <returns></returns>
        public string Welcome()
        {
            Console.Write("Nice to meet you! What is your name? ");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("\n\nMy goal in this program is to count the letters in a phrase.");
            
            return "placeholder";
        }

        /// <summary>
        /// reads text from command line
        /// </summary>
        public void ReadText()
        {
            Console.Write("Please enter a phrase: ");
            phrase = Console.ReadLine().Trim();
        }

        /// <summary>
        /// Reads text from file
        /// </summary>
        public void ReadText(string filename)
        {
            StreamReader myReader = new StreamReader(filename);

            // read data

            myReader.Close();
        }

        /// <summary>
        /// Counts number of letters in phrase
        /// </summary>
        /// <returns></returns>
        public void Counting()
        {
            int counter = 0;
            // count letters in phrase
            // loop to get each letter

                // go through the phrase for each letter in the alphabet
                // if letters occur add that to the num letter list
        }
    }
}
