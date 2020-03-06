using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Fields_n_Methods
{
    // Cie Thompson
    // 3/6/20
    // Classes Fields and Methods PE

    class Program
    {
        static void Main(string[] args)
        {
            // declare and instantiate
            RPGCharacter myCharacter = new RPGCharacter("Lizzie", 5, 30, 14, 26, 100);
            myCharacter.PrintInformation();
            Console.WriteLine();

            // reduce health by 4
            for (int i = 0; i < 4; i++)
            {
                myCharacter.DecreaseHealth();
            }

            // strength++ dex++
            myCharacter.IncreaseStrength();
            myCharacter.IncreaseDexterity();

            // intelligence++
            myCharacter.IncreaseIntelligence();

            // +300 exp
            myCharacter.GainExperience(300);

            // final print
            Console.WriteLine();
            myCharacter.PrintInformation();
        }
    }
}
