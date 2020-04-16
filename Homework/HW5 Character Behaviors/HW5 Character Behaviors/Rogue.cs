using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Character_Behaviors
{
    /// <summary>
    /// Rogue child class (inherits from common character class)
    /// </summary>
    class Rogue : CommonCharacter
    {
        private int agility;
        private int stealth;
        private int damageAvoided;

        // constructor
        public Rogue(int health, int strength, int dexterity, int level, int agility, int stealth, Random rng)
            : base(health, strength, dexterity, level, rng)
        {
            this.agility = agility;
            this.stealth = stealth;
            this.damageAvoided = (agility + stealth);
        }

        // ToString Override
        /// <summary>
        /// Prints character stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "The Wizard has " + health + " health, " + strength + " strength, and " +
                dexterity + " dexterity.\n" + "They are level " + level + " and currently have " + 
                agility + " agility and " + stealth + " stealth points,\nallowing them to avoid " + 
                damageAvoided + " damage.";
        }

        // attack method
        /// <summary>
        /// generates a number for attack based on strength and dexterity.
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            int attack = (RNG.Next(0, strength) * dexterity);
            return attack;
        }

        // take damage method
        /// <summary>
        /// Reduces health based on damage taken and damage avoided
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            this.health -= (damage + damageAvoided);
        }

        // HasFled()
        /// <summary>
        /// Flees based on health remaining
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
