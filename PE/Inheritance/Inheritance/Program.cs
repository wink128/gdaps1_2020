using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Cie Thompson
    // 4/8/20
    // Inheritance PE

    class Program
    {
        static void Main(string[] args)
        {
            // default enemy
            Enemy defaultEnemy = new Enemy();
            defaultEnemy.Print();
            Console.WriteLine();

            // diamond enemy
            Diamond enemy1 = new Diamond();
            enemy1.Print();
            Console.WriteLine("Unique trait: chases you is {0}",
                enemy1.ChasesYou);
            Console.WriteLine();

            // square enemy
            Square enemy2 = new Square();
            enemy2.Print();
            Console.WriteLine("Unique trait: scared is {0}",
                enemy2.IsScared);
            Console.WriteLine();

            // pinwheel enemy
            Pinwheel enemy3 = new Pinwheel();
            enemy3.Print();
            Console.WriteLine("Unique trait: bounces is {0}",
                enemy3.CanBounce);
            Console.WriteLine();

            // x enemy
            X enemy4 = new X();
            enemy4.Print();
            Console.WriteLine("Unique trait: number of smaller x's is {0}",
                enemy4.SplitsInto);
            Console.WriteLine();
        }
    }
}
