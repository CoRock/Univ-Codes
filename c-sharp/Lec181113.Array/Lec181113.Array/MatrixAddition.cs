using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181113.Array
{
    class MatrixAddition
    {
        static int[,] add(int[,] a, int[,] b)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int[,] c = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    c[i, j] = a[i, j] + b[i, j];

            return c;
        }

        static void Main(string[] args)
        {
            int[,] x = new int[2, 3];
            int[,] y = { { 7, 2, 9 },
                         { 1, 3, 2 } };

            x[0, 0] = 3;
            x[0, 1] = 5;
            x[0, 2] = 7;
            x[1, 0] = 1;
            x[1, 1] = 3;
            x[1, 2] = 1;

            int[,] z;

            z = add(x, y);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(z[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
