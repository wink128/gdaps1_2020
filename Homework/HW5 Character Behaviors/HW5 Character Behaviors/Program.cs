using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Character_Behaviors
{
    // Cie Thompson
    // 4/16/20
    // HW5 Character behaviors

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wizard Vs. Rogue \nWelcome to the battle!");
            Wizard wiz = new Wizard(60, 4, 3, 7, 2, 2);
            Rogue rog = new Rogue(40, 4, 3, 8, 6, 5);

            // Char stats
            Console.WriteLine(wiz.ToString());  // wizard
            Console.WriteLine();
            Console.WriteLine(rog.ToString());  // rogue

            // damage
            int wizAtk;
            int rogAtk;

            int round = 1;
            while (wiz.IsDead() == false && rog.IsDead() == false && wiz.HasFled() == false && rog.HasFled() == false)
            {
                // scroll speed
                System.Threading.Thread.Sleep(500);

                // damage update
                wizAtk = wiz.Attack();
                rogAtk = rog.Attack();
                wiz.TakeDamage(rogAtk);
                rog.TakeDamage(wizAtk);

                Console.WriteLine();
                Console.WriteLine("Round {0} ---------------------------------", round);
                Console.WriteLine();
                Console.WriteLine("The wizard deals {0} damage to the rogue.", wizAtk);
                Console.WriteLine("The rogue deals {0} damage to the wizard.", rogAtk);
                Console.WriteLine();
                Console.WriteLine("The rogue has {0} health left.", rog.Health);
                Console.WriteLine("The wizard has {0} health left.", wiz.Health);
                Console.WriteLine();
                round++;
            }

            // game over
            Console.WriteLine("\nGAME OVER!");

            // win/loss evaluation
            if (rog.IsDead()==true&&(wiz.HasFled()==false && wiz.IsDead() == false))
            {
                Console.WriteLine("The wizard has slain the rogue!");
            }
            else if (rog.HasFled()==true&& (wiz.HasFled() == false && wiz.IsDead() == false))
            {
                Console.WriteLine("Rogue has fled! Wizard wins!");
            }
            else if (wiz.IsDead() == true && (rog.HasFled() == false && rog.IsDead() == false))
            {
                Console.WriteLine("The rogue has slain the wizard!");
            }
            else if (wiz.HasFled() == true && (rog.HasFled() == false && rog.IsDead() == false))
            {
                Console.WriteLine("Wizard has fled! Rogue wins!");
            }
            else
            {
                Console.WriteLine("Both players either fled or died. No winners here :(");
            }

        }
    }
}
