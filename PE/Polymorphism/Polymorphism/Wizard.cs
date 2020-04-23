using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Wizard character class 
    /// </summary>
    class Wizard : RPG_Character
    {
        // fields
        public double hotPocketPercentage;

        // constructor
        public Wizard(string name, int strength, int dexterity, int intelligence, double hotPocketPercentage)
            : base(name, strength, dexterity, intelligence)
        {
            this.hotPocketPercentage = hotPocketPercentage;
        }

        // property
        public double HotPocketPercentage
        {
            get { return hotPocketPercentage; }
            set { hotPocketPercentage = value; }
        }

        // to string override
        /// <summary>
        /// Prints unique character stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "\n" + name + " is a wizard and has conjured " +
                hotPocketPercentage + "% hot pockets today.";
        }

        // get experience override
        /// <summary>
        /// Updates experience
        /// </summary>
        /// <param name="experience"></param>
        /// <returns></returns>
        public override int GainExperience(int experience)
        {
            if (experience > 200)
            {
                intelligence++;
            }

            base.GainExperience(experience);

            this.hotPocketPercentage -= hotPocketPercentage / 2;

            return this.experience;
        }

    }
}
