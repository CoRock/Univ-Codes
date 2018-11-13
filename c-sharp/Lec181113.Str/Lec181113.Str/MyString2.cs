using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181113.Str
{
    class MyString2
    {
        static void Main(string[] args)
        {
            // String s = "";
            System.Text.StringBuilder s = new System.Text.StringBuilder("");

            for (int i = 0; i < 10; i++)
            {
                // s = s + "kim";
                s.Append("kim");
            }
            Console.WriteLine(s);

            s = s.Replace('i', 'o');
            Console.WriteLine(s);
        }
    }
}
