using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Warrior character class
    /// </summary>
    class Warrior : RPG_Character
    {
        // fields
        public int daysSinceLastBath;

        // constructor
        public Warrior(string name, int strength, int dexterity, int intelligence, int daysSinceLastBath)
            : base(name, strength, dexterity, intelligence)
        {
            this.daysSinceLastBath = daysSinceLastBath;
        }

        // property 
        public int DaysSinceLastBath
        {
            get { return daysSinceLastBath; }
            set { daysSinceLastBath = value; }
        }

        // to string override
        /// <summary>
        /// Prints unique character stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "\n"+ name + " is a warrior and it has been " +
                daysSinceLastBath + " day(s) since their last bath.";
        }

        // unique method
        /// <summary>
        /// resets days since last bath
        /// </summary>
        public void TakeBath()
        {
            Console.WriteLine("{0} takes a bath!", name);
            daysSinceLastBath = 0;
        }

        // get experience override
        /// <summary>
        /// Update Experience
        /// </summary>
        /// <param name="experience"></param>
        /// <returns></returns>
        public override int GainExperience(int experience)
        {
            if (experience > 200)
            {
                strength++;
            }

            base.GainExperience(experience);

            return this.experience;
        }
    }
}
