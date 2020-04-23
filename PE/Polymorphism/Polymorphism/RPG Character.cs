using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Basic RPG Character parent class
    /// </summary>
    class RPG_Character
    {
        // fields
        protected string name;
        protected int strength;
        protected int dexterity;
        protected int intelligence;
        protected int experience;

        // constructor
        public RPG_Character(string name, int strength, int dexterity, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.experience = 0;
        }

        // properties
        public string Name
        {
            get { return name; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Dexterity
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public int Experience
        {
            get { return experience; }
        }

        // to string override
        /// <summary>
        /// Prints out character's base stats.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name + "'s strength is " + strength + "; dexterity is " + dexterity +
                "; intelligence is " + intelligence + "; total experience is " + experience + ".";
        }

        // gain experience method
        /// <summary>
        /// Increases character's experience by parameter value.
        /// </summary>
        /// <param name="experience"></param>
        /// <returns></returns>
        public virtual int GainExperience(int experience)
        {
            this.experience += experience;
            return this.experience;
        }
    }
}
