using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// Thief character class
    /// </summary>
    class Thief : RPG_Character
    {
        // field
        public int cellPhoneRings;

        // constructor
        public Thief(string name, int strength, int dexterity, int intelligence, int cellPhoneRings)
            : base(name, strength, dexterity, intelligence)
        {
            this.cellPhoneRings = cellPhoneRings;
            Console.WriteLine("Thief is spawned.");
        }

        // property
        public int CellPhoneRings
        {
            get { return cellPhoneRings; }
            set { cellPhoneRings = value; }
        }

        // to string override
        /// <summary>
        /// Prints unique character stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "\n" + name + " is a thief and their cell phone rang " +
                cellPhoneRings + " times today.";
        }

        // unique method
        /// <summary>
        /// Thief smashes phone
        /// </summary>
        public void SmashPhone()
        {
            Console.WriteLine("{0} accidentally smashes their phone.", name);
            cellPhoneRings = 0;
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
                dexterity++;
            }

            base.GainExperience(experience);

            this.cellPhoneRings = cellPhoneRings / 2;

            return this.experience;
        }
    }
}
