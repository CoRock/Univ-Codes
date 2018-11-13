using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181113.Array
{
    class Program
    {
        // function overloading
        static int getSum(int[][] s)
        {
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    sum = sum + s[i][j];
                }
            }
            return sum;
        }

        static int getSum(int[,] s)
        {
            int sum = 0;

            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    sum = sum + s[i, j];
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[,] x;
            x = new int[2, 3];

            x[1, 2] = 5;
            x[0, 1] = 7;

            /**
             * GetLength(0): return row count
             * GetLength(1): return col count
             * GetLength(2) will be used three-dimensional arrays
             * ...
             */
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            int s = getSum(x);
            Console.WriteLine("getSum(): " + s);

            /***************************************************/
            Console.WriteLine("-------------------------------");
            /***************************************************/

            int[][] y;
            y = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                y[i] = new int[3];
            }

            y[1][2] = 5;
            y[0][1] = 7;
            
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y[i].Length; j++)
                {
                    Console.Write(y[i][j] + " ");
                }
                Console.WriteLine();
            }
            s = getSum(y);
            Console.WriteLine("getSum(): " + s);
        }
    }
}
