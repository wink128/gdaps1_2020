using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Enemy
    {
        private string name;
        private int health;

        public Enemy(string enemyName, int startingHealth)
        {
            this.name = enemyName;
            this.health = startingHealth;
        }

        public void Print()
        {
            Console.WriteLine("{0} has {1} health.", name, health);
        }
    }
}
