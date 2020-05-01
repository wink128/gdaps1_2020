using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThompsonCieHW14
{
    /// <summary>
    /// 
    /// </summary>
    class User
    {
        // attributes
        string username;
        string[] randomNames = new string[] { "Mio", "Ace", "Chad" };
        Random rng;

        // property
        public string UserName
        {
            get { return username; }
            set
            {
                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine("\nName not entered. Your name will be randomized.");
                    this.username = randomNames[rng.Next(3)];
                }
                else this.username = value;
            }
        }

        // constructor
        public User()
        {
            rng = new Random();
        }

        // methods
        /// <summary>
        /// Asks user for input 
        /// </summary>
        public string UserInput()
        {
            Console.WriteLine("How would you like me to count text?\n1) You will ENTER it" +
                "\n2) You have a FILE with text in it\n3) QUIT");
            string choice = Console.ReadLine().Trim().ToLower();
            return choice;
        }

        /// <summary>
        /// Returns file name
        /// </summary>
        /// <returns></returns>
        public string UserFileName()
        {
            return "placeholder";
        }

        /// <summary>
        /// displays data with a random text color
        /// </summary>
        /// <param name="myList"></param>
        /// <param name="phrase"></param>
        public void DisplayData(List<string> alphList, List<int> numList, string[] phrase)
        {
            // if counter list > 0 display data
            // do not display otherwise
            for (int i=0; i<phrase.Length; i++)
            {
                if (numList[i] > 0)
                {
                    Console.ForegroundColor = (ConsoleColor)rng.Next(16);
                    Console.WriteLine("The letter {0} was found {1} time(s)", numList[i], alphList[i]);
                }
                else
                {
                    continue;
                }
            }

            // pick random text color
        }
    }
}
