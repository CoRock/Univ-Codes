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

        static int[,] sub(int[,] a, int[,] b)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int[,] c = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    c[i, j] = a[i, j] - b[i, j];

            return c;
        }

        static int[,] mul(int c, int[,] x)
        {
            int m = x.GetLength(0);
            int n = x.GetLength(1);
            int[,] y = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    y[i, j] = c * x[i, j];

            return y;
        }

        static int[,] mul(int[,] a, int[,] b)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int l = b.GetLength(1);

            int[,] c = new int[m, l];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < l; k++)
                    {
                        sum = sum + a[i, k] * b[k, j];
                    }
                    c[i, j] = sum;
                }
            }
            
            return c;
        }

        static void print(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    Console.Write(x[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
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
            Console.WriteLine("add: ");
            print(z);

            z = sub(x, y);

            Console.WriteLine("subtract: ");
            print(z);

            z = mul(3, x);
            Console.WriteLine("scalar multiplication: ");
            print(z);

            int[,] p = { { 100, 50 }, { 200, 150 }, { 150, 70 } };
            z = mul(x, p);
            Console.WriteLine("matrix multiplication: ");
            print(z);
        }
    }
}
