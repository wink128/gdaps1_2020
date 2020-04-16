using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Character_Behaviors
{
    /// <summary>
    /// Wizard child class (common character base class)
    /// </summary>
    class Wizard : CommonCharacter
    {
        private int spellsLearned;
        private int mastery;
        private int bonusDamage;

        // constructor
        public Wizard(int health, int strength, int dexterity, int level, int spellsLearned, int mastery, Random rng)
            : base(health, strength, dexterity, level, rng)
        {
            this.spellsLearned = spellsLearned;
            this.mastery = mastery;
            this.bonusDamage = (spellsLearned * mastery);
        }

        // ToString Override
        /// <summary>
        /// Print wizard's stat's to the console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return "The Wizard has " + health + " health, " + strength + " strength, and " +
                dexterity + " dexterity.\n" + "They are level " + Level + " , currently know " + 
                spellsLearned + " spells, and have " + mastery + " mastery points, \nallowing them to do " + bonusDamage + " bonus damage.";
        }

        // attack method
        /// <summary>
        /// Generates an attack based on strength dexterity and bonus damage
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            int attack = (RNG.Next(0, strength) * dexterity) + bonusDamage;
            return attack;
        }

        // take damage method
        /// <summary>
        /// Reduces health based on damage taken
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            
            this.health -= damage;
        }

        // HasFled()
        /// <summary>
        /// Flees depending on remaining health
        /// </summary>
        /// <returns></returns>
        public bool HasFled()
        {
            if (health > 10)
            {
                return false;
            }
            else if (health <= 10 && health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // IsDead()
        /// <summary>
        /// Evaluates if player is dead or not
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            if (health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
