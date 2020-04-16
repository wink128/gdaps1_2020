using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Character_Behaviors
{
    class Rogue : CommonCharacter
    {
        private int agility;
        private int stealth;
        private int damageAvoided;

        // constructor
        public Rogue(int health, int strength, int dexterity, int level, int agility, int stealth)
            : base(health, strength, dexterity, level)
        {
            this.agility = agility;
            this.stealth = stealth;
            this.damageAvoided = (agility + stealth);
        }

        // ToString Override
        public override string ToString()
        {
            return "The Wizard has " + health + " health, " + strength + " strength, and " +
                dexterity + " dexterity." + "They are level " + level + " and currently have " + 
                agility + " agility and " + stealth + " stealth points, allowing them to avoid " + 
                damageAvoided + " damage.";
        }

        // attack method
        public int Attack()
        {
            int attack = (RNG.Next(0, strength) * dexterity) + damageAvoided;
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
