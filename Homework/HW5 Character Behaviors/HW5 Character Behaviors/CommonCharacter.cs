using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Character_Behaviors
{
    class CommonCharacter
    {
        // Fields
        protected int health;
        protected int strength;
        protected int dexterity;
        protected int level;
        protected Random rng = new Random();

        // Constructor
        public CommonCharacter(int health, int strength, int dexterity, int level)
        {
            this.health = health;
            this.strength = strength;
            this.dexterity = dexterity;
            this.level = level;
        }

        // Properties
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Strength
        {
            get { return strength; }
        }
        public int Dexterity
        {
            get { return dexterity; }
        }
        public int Level
        {
            get { return level; }
        }
        public Random RNG
        {
            get { return rng; }
        }
    }
}
