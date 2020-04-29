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
        string[] randomNames;
        Random rng;

        // property
        public string UserName
        {
            get { return username; }
            set
            {
                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine("\nName not entered. Your new name is Mio.");
                    username = "Mio";
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
            return "placeholder";
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
        public void DisplayData(List<string> myList, string phrase)
        {
            // if counter list > 0 display data
            // do not display otherwise

            // pick random text color
        }
    }
}
