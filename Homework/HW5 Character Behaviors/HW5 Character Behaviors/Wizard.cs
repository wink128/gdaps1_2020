using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Character_Behaviors
{
    class Wizard : CommonCharacter
    {
        private int spellsLearned;
        private int mastery;
        private int bonusDamage;

        // constructor
        public Wizard(int health, int strength, int dexterity, int level, int spellsLearned, int mastery)
            : base(health, strength, dexterity, level)
        {
            this.spellsLearned = spellsLearned;
            this.mastery = mastery;
            this.bonusDamage = (spellsLearned * mastery);
        }

        // ToString Override
        public override string ToString()
        {

            return "The Wizard has " + health + " health , " + strength + " strength, and " +
                dexterity + " dexterity. " + " They are level " + Level + "and currently know " + 
                spellsLearned + " spells and have level " + mastery + " mastery, allowing them to do " + bonusDamage + " bonus damage.";
        }

        // attack method
        public int Attack()
        {
            int attack = (RNG.Next(0, strength) * dexterity) + bonusDamage;
            return attack;
        }

        // take damage method
        public void TakeDamage(int damage)
        {
            
            this.health -= damage;
        }

        // HasFled()
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
