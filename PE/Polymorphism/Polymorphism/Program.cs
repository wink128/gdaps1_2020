using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            Barracks myBarracks = new Barracks(rng);

            List<RPG_Character> list = new List<RPG_Character>();

            // this should add the random characters into the list
            for (int i = 0; i < 10; i++)
            {
                list.Add(myBarracks.SpawnCharacter("character " + (i+1), rng.Next(21), rng.Next(21), rng.Next(21)));
            }

            // this is supposed to print the stats but its not printing anything
            foreach (RPG_Character character in list)
            {
                character.ToString();
            }
        }
    }
}
