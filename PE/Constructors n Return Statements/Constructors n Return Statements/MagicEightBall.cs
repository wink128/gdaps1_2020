using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_n_Return_Statements
{
    /// <summary>
    /// Magic Eight Ball with specific programmed responses
    /// </summary>
    
    class MagicEightBall
    {
        // fields
        private string owner;
        private int timesShaken;
        private string[] responses;
        Random rng;

        // parametrized constructor
        public MagicEightBall(string owner)
        {
            this.owner = owner;
            timesShaken = 0;
            responses = new string[5];
            responses[0] = "It is certain.";
            responses[1] = "Don't count on it.";
            responses[2] = "Ask again later.";
            responses[3] = "Very doubtful.";
            responses[4] = "Without a doubt.";
        }

        // default constructor
        public MagicEightBall()
        {
            owner = "Person";
            timesShaken = 0;
            responses = new string[5];
            responses[0] = "It is certain.";
            responses[1] = "Don't count on it.";
            responses[2] = "Ask again later.";
            responses[3] = "Very doubtful.";
            responses[4] = "Without a doubt.";
            rng = new Random();
        }

        // methods
        /// <summary>
        /// Simulates shaking the 8 ball.
        /// </summary>

        public string ShakeBall()
        {
            timesShaken++;
            return responses[rng.Next(5)];
        }

        /// <summary>
        /// Returns the number of times shaken as a string
        /// </summary>

        public string Report()
        {
            return timesShaken.ToString();
        }

    }
}
