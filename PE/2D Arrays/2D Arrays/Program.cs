using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Arrays
{
    class Program
    {
        // Cie Thompson
        // 2/24/20
        // 2D Arrays PE

        static void Main(string[] args)
        {
            // RNG
            Random rng = new Random();
            
            // Array declaration + initialization
            char[,] grid = new char[10, 15];

            // Hard coded words
            grid[1, 7] = (char)109;   // m
            grid[1, 8] = (char)105;   // i
            grid[1, 9] = (char)109;   // m
            grid[1, 10] = (char)105;  // i
            grid[1, 11] = (char)107;  // k
            grid[1, 12] = (char)121;  // y
            grid[1, 13] = (char)117;  // u

            grid[4, 4] = (char)115;   // s
            grid[4, 5] = (char)108;   // l
            grid[4, 6] = (char)117;   // u
            grid[4, 7] = (char)103;   // g
            grid[4, 8] = (char)109;   // m
            grid[4, 9] = (char)97;    // a

            grid[7, 1] = (char)112;   // p
            grid[7, 2] = (char)111;   // o
            grid[7, 3] = (char)107;   // k
            grid[7, 4] = (char)101;   // e
            grid[7, 5] = (char)109;   // m
            grid[7, 6] = (char)111;   // o
            grid[7, 7] = (char)110;   // n

            // rng letters
            // the ASCII codes are between 97 and 122
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j]==0)
                    {
                        grid[i, j] = (char)rng.Next(97, 123);
                    }
                    
                }
            }

            // Print Grid
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
