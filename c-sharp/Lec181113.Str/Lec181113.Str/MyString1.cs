using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181113.Str
{
    class MyString1
    {
        static void Main(string[] args)
        {
            String x;
            String a = "";
            String b = new String('x', 5);

            // shallow copy
            String c = "world";
            String d = c;

            // deep copy
            String e = "world";

            // Console.WriteLine(x + "." + a + "." + b + "." + c + "." + d);
            Console.WriteLine(a.ToString() + "." + b + "." + c + "." + d + "." + e);

            // x = x + "hello" + "world";
            a = a + "hello" + "world";
            Console.WriteLine("a: " + a);
            Console.WriteLine();

            b = a = "Hi, Prof. Kim";
            c = a + b;
            d = d + " How are you?";

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
        }
    }
}
