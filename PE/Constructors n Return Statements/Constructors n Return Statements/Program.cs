using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_n_Return_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8 ball creation + introduction
            Console.WriteLine("Welcome to the Magic 8 Ball simulator!\n\t");
            Console.Write("> Who owns this ball? ");
            string owner = Console.ReadLine().Trim();
            MagicEightBall myBall = new MagicEightBall(owner);

            // simulation loop
            Console.WriteLine("What would you like to do?\n\t");
            Console.
        }
    }
}
