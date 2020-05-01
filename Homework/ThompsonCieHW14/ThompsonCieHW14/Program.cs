using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThompsonCieHW14
{
    // Cie Thompson
    // 4/27/20
    // Text file and counting program
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();

            string name = TextAnalyze.Welcome();
            newUser.UserName = name;
            Console.WriteLine();
            newUser.UserInput();
            TextAnalyze.ReadText();
            TextAnalyze.Counter();
        }
    }
}
