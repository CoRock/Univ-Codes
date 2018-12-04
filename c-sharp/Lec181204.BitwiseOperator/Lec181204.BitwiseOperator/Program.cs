using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181204.BitwiseOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            x = 5;
            y = 6;

            z = x | y;      // OR operator
            Console.WriteLine("x | y: " + z);

            z = x & y;      // AND operator
            Console.WriteLine("x & y: " + z);

            z = ~x;         // negation x
            Console.WriteLine("~x: " + z);

            x = 0;
            z = ~x;
            Console.WriteLine("~x: " + z);

            x = 6;
            z = x << 2;
            Console.WriteLine("6 << 2: " + z);

            x = 24;
            z = x >> 2;
            Console.WriteLine("24 >> 2: " + z);

            z = 1 << 31;
            Console.WriteLine("1 << 31: " + z);

            z = ~(1 << 31);
            Console.WriteLine("~(1 << 31): " + z);

            x = 31;
            y = 23;
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}
