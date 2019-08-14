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

    class MatrixFlexible
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

        static int readInt()
        {
            String s = Console.ReadLine();
            return int.Parse(s);
        }

        static void Main(string[] args)
        {
            int m, n;
            int i, j;

            Console.WriteLine("2차원 배열 두 개를 입력해주세용... 용용 죽겠지...");
            Console.Write("행값은 얼마인가용? ");
            m = readInt();
            Console.Write("열값은 얼마인가용? ");
            n = readInt();

            Matrix A = new Matrix(m, n);
            Console.WriteLine("첫번째 배열 A에 들어갈 데이터를 쳐 주세요.");
            A.readFromConsole();

            Matrix B = new Matrix(m, n);
            Console.WriteLine("두번째 배열 B에 들어갈 데이터를 쳐 주세요.");
            B.readFromConsole();

            Console.WriteLine("A = \n" + A);
            Console.WriteLine("B = \n" + B);

            Matrix C;
            C = A.add(B);
            Console.WriteLine("C = \n" + C);

        }
    }
}
