using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy myEnemy = new Enemy("Bertha", 200);
            myEnemy.Print();
        }
    }
}
