using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181108.Str
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            String a = "";
            String b = new String('x', 5);

            // shallow copy
            String c = "world";
            String d = "b";

            // deep copy
            String e = "world";

            // Console.WriteLine(x + "." + a + "." + b + "." + c + "." + d);
            Console.WriteLine(a + "." + b + "." + c + "." + d + "." + e);

            // x = x + "hello" + "world";
            a = a + "hello" + "world";
        }
    }
}
