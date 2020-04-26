using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // file writing
            StreamWriter writer = null;
            FileStream readStream;

            // file reading
            StreamReader reader = null;

            // string list
            List<string> enemyList = new List<string>();

            // int list
            List<int> damageList = new List<int>();

            // menu loop
            string choice = null;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose one of the following options:\n" +
                "1 - Enter Data\n2 - Save Data\n3 - Load Data\n4 - Quit\n> ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                choice = Console.ReadLine().Trim().ToLower();
                Console.ForegroundColor = ConsoleColor.White;


                switch (choice)
                {
                    case "1":
                    case "enter data":
                        Console.WriteLine();
                        Console.Write("How many enemies are there? ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        int numPlayers = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int i = 0; i < numPlayers; i++)
                        {
                            // player names
                            Console.Write("\tEnter player {0}'s name: ", i + 1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            string enemyName = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            enemyList.Add(enemyName);

                            // damage
                            Console.Write("\tEnter player {0}'s damage: ", i + 1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            int enemyDmg = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            damageList.Add(enemyDmg);
                        }
                        break;
                    case "2":
                    case "save data":
                        if (enemyList.Count != 0)
                        {
                            Console.WriteLine("Saving enemy names to the file.\nFile saved.");

                            // creating the file can't be in the loop 
                            //because it will create a new file
                            try
                            {
                                readStream = File.OpenRead("enemytext.txt");
                                writer = new StreamWriter(readStream);
                                for (int i = 0; i < enemyList.Count; i++)
                                {
                                    writer.WriteLine(enemyList[i] + "," + damageList[i]);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Write("Error writing: " + e.Message);
                            }

                            if (writer != null)
                            {
                                writer.Close();
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is nothing to save.");
                        }
                        break;
                    case "3":
                    case "load data":
                        if (enemyList.Count != 0)
                        {
                            Console.WriteLine("Loading data from file.\n" +
                                "(Here are all enemies from the file: ");
                            enemyList.Clear();
                            damageList.Clear();

                            try
                            {
                                readStream = File.OpenRead("enemytext.txt");
                                // opening the file
                                reader = new StreamReader(readStream);
                                string line = null;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    Console.WriteLine("\t" + line);
                                    enemyList.Add(line);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Write("Error writing: " + e.Message);
                            }
                            reader.Close();
                        }
                        else
                        {
                            Console.WriteLine("There is no enemy data to load.");
                        }
                        break;
                    case "4":
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("Choice invalid.");
                        break;
                }
                Console.WriteLine();
            } while (choice != "4" && choice != "quit");
        }
    }
}
