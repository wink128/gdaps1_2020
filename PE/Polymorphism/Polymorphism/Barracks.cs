using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Generates a random RPG Character
    /// </summary>
    class Barracks
    {
        // field
        public Random rng;
        
        // constructor
        public Barracks(Random rng)
        {
            this.rng = rng;
        }
        
        // property
        public Random RNG
        {
            get { return rng; }
        }

        // method
        /// <summary>
        /// Actually spawns in a random RPG Character type
        /// </summary>
        /// <returns></returns>
        public RPG_Character SpawnCharacter(string name, int strength, int dexterity, int intelligence)
        {
            int spawnChar = rng.Next(101);

            // rules for character creation
            if (spawnChar <= 10)
            {
                int phoneRings = rng.Next(21);
                Thief myThief = new Thief(name, strength, dexterity, intelligence, phoneRings);
                return myThief;
            }
            else if (spawnChar > 10 && spawnChar <= 40)
            {
                int hotPocket = rng.Next(21);
                Wizard myWiz = new Wizard(name, strength, dexterity, intelligence, hotPocket);
                return myWiz;
            }
            else 
            {
                int lastBath = rng.Next(21);
                Warrior myWarrior = new Warrior(name, strength, dexterity, intelligence, lastBath);
                return myWarrior;
            }

        }

    }
}
