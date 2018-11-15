using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Variable-length arrays
 */
namespace Lec181113.Array
{
    class MyArray2
    {
        static void Main(string[] args)
        {
            // syntax error: int[][] x = new int[3][4];
            int[][] x = new int[4][];
            x[0] = new int[4];
            x[1] = x[0];
            x[2] = new int[2];
            x[3] = x[2];
            // x[1] = new int[5];
            // x[3] = new int[3];

            int count = 1;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    x[i][j] = count;
                    count++;
                }
            }

            x[2][1] = 100;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    Console.Write(x[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
