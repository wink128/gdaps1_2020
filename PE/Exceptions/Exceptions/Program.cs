using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exception excercise!\n");

            CustomList myList;

            try
            {
                myList = new CustomList(-3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                myList = new CustomList();
            }

            try
            {
                myList.Add("Leila");
                Console.WriteLine();
                Console.WriteLine("Printing names in list:");
                Console.WriteLine(myList.GetElement(0));
                Console.WriteLine(myList.GetElement(1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Done!");
        }
    }
}
