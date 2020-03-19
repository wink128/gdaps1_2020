using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Fields_n_Methods
{
    /// <summary>
    /// Creates an RPG character with specific stats
    /// </summary>

    class RPGCharacter
    {
        // fields
        private string name;
        private int strength;
        private int dexterity;
        private int intelligence;
        private int health;
        private int speed;
        private int experience;

        // Constructor
        public RPGCharacter(string name, int strength, int health, int dexterity,
            int intelligence, int experience)
        {
            this.name = name;
            this.strength = strength;
            this.health = health;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.experience = experience;
            speed = (health + dexterity) / 4;
        }

        // methods
        public void IncreaseHealth()
        {
            health += 1;
            Console.WriteLine("{0}'s health increased by 1 point!", name);
            speed = (health + dexterity) / 4;
        }
        public void IncreaseStrength()
        {
            strength += 1;
            Console.WriteLine("{0}'s strength increased by 1 point!", name);
        }

        public void IncreaseDexterity()
        {
            dexterity += 1;
            Console.WriteLine("{0}'s dexterity increased by 1 point!", name);
            speed = (health + dexterity) / 4;
        }

        public void IncreaseIntelligence()
        {
            intelligence += 1;
            Console.WriteLine("{0}'s intelligence increased by 1 point!", name);
        }

        public void DecreaseHealth()
        {
            health -= 1;
            Console.WriteLine("{0}'s health decreased by 1 point!", name);
            speed = (health + dexterity) / 4;
        }

        public void DecreaseStrength()
        {
            strength -= 1;
            Console.WriteLine("{0}'s strength decreased by 1 point!", name);
        }

        public void DecreaseDexterity()
        {
            dexterity -= 1;
            Console.WriteLine("{0}'s dexterity decreased by 1 point!", name);
            speed = (health + dexterity) / 4;
        }

        public void DecreaseIntelligence()
        {
            intelligence -= 1;
            Console.WriteLine("{0}'s intelligence decreased by 1 point!", name);
        }

        public void GainExperience(int experienceToGain)
        {
            experience += experienceToGain;
            Console.WriteLine("{0}'s experience is increased to {1}!", name, experience);
        }

        public void PrintInformation()
        {
            Console.WriteLine("RPG Character\n\tName: {0} \n\tStrength: {1}\n\t" +
                "Dexterity: {2}\n\tIntelligence: {3}\n\tHealth: {4}\n\tSpeed; {5}" +
                "\n\tExperience: {6}", 
                name, strength, dexterity, intelligence, health, speed, experience);
        }
    }
}
