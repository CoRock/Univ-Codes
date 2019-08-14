using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181113.Array
{
    class Matrix
    {
        int[][] m_ptr;
        int m_row;
        int m_col;

        // default constructor
        public Matrix()
        {
            m_row = 0;
            m_col = 0;
            m_ptr = null;
        }
        public Matrix(int row, int col)
        {
            m_row = row;
            m_col = col;
            m_ptr = new int[row][];

            for (int i = 0; i < row; i++)
            {
                m_ptr[i] = new int[col];
            }
        }

        public void set(int i, int j, int x)
        {
            m_ptr[i][j] = x;
        }

        public Matrix add(Matrix m)
        {
            if (this.m_row != m.m_row || m_col != m.m_col)
            {
                Console.WriteLine("Error!");
                Environment.Exit(-1);
            }
            Matrix tmp = new Matrix(m_row, m_col);
            for (int i = 0; i < m_row; i++)
                for (int j = 0; j < m_col; j++)
                    tmp.m_ptr[i][j] = m_ptr[i][j] + m.m_ptr[i][j];

            return tmp;
        }

        public Matrix sub(Matrix m)
        {
            if (this.m_row != m.m_row || m_col != m.m_col)
            {
                Console.WriteLine("Error!");
                Environment.Exit(-1);
            }
            Matrix tmp = new Matrix(m_row, m_col);
            for (int i = 0; i < m_row; i++)
                for (int j = 0; j < m_col; j++)
                    tmp.m_ptr[i][j] = m_ptr[i][j] - m.m_ptr[i][j];

            return tmp;
        }

        public Matrix mul(int c)
        {
            Matrix tmp = new Matrix(m_row, m_col);
            for (int i = 0; i < m_row; i++)
                for (int j = 0; j < m_col; j++)
                    tmp.m_ptr[i][j] = c * m_ptr[i][j];

            return tmp;
        }

        public Matrix mul(Matrix m)
        {
            if (m_col != m.m_row)
            {
                Console.WriteLine("Error!");
                Environment.Exit(-1);
            }
            Matrix tmp = new Matrix(m_row, m.m_col);

            for (int i = 0; i < m_row; i++)
            {
                for (int j = 0; j < m.m_col; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m.m_col; k++)
                    {
                        sum = sum + m_ptr[i][k] * m.m_ptr[k][j];
                    }
                    tmp.m_ptr[i][j] = sum;
                }
            }

            return tmp;
        }

        public override string ToString()
        {
            String s = "";
            for (int i = 0; i < m_row; i++)
            {
                for (int j = 0; j < m_col; j++)
                {
                    s = s + m_ptr[i][j] + " ";
                }
                s = s + "\n";
            }
            return s;
        }

        public void readFromConsole()
        {
            Console.WriteLine("Please enter data: ");
            for (int i = 0; i < m_row; i++)
            {
                for (int j = 0; j < m_col; j++)
                {
                    Console.Write("data[" + i + "][" + j + "] = ");
                    String s = Console.ReadLine();
                    int data = int.Parse(s);
                    m_ptr[i][j] = data;
                }
            }
            Console.WriteLine();
        }
    }

    class MatrixOOP
    {
        static void Main(string[] args)
        {
            Matrix x = new Matrix(2, 3);
            Matrix y = new Matrix(2, 3);
            Matrix z;

            x.readFromConsole();
        /*
            x.set(0, 0, 3);
            x.set(0, 1, 5);
            x.set(0, 2, 7);
            x.set(1, 0, 1);
            x.set(1, 1, 3);
            x.set(1, 2, 1);
        */

            y.readFromConsole();
        /*
            y.set(0, 0, 7);
            y.set(0, 1, 2);
            y.set(0, 2, 9);
            y.set(1, 0, 1);
            y.set(1, 1, 3);
            y.set(1, 2, 2);
        */

            z = x.add(y);
            Console.WriteLine("add: ");
            Console.WriteLine(z);

            Console.WriteLine("x, y, z: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            z = x.sub(y);
            Console.WriteLine("subtract: ");
            Console.WriteLine(z);

            z = x.mul(3);
            Console.WriteLine("scalar multiplication: ");
            Console.WriteLine(z);

            Matrix p = new Matrix(3, 2);
            p.set(0, 0, 3);
            p.set(0, 1, 2);
            p.set(1, 0, 1);
            p.set(1, 1, 3);
            p.set(2, 0, 2);
            p.set(2, 1, 5);

            z = x.mul(p);
            Console.WriteLine("matrix multiplication: ");
            Console.WriteLine(z);
        }
    }
}
