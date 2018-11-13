using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181113.Str
{
    class PerformComp
    {
        static void Main(string[] args)
        {
            // String s = "hello";
            System.Text.StringBuilder s = new System.Text.StringBuilder("hello");
            long start = DateTime.Now.Ticks;

            for (int i = 0; i < 20000; i++) { s = s.Append("hello"); }
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    // s = s.Replace('o', 'a');
                    s.Replace('o', 'a');
                }
                else
                {
                    // s = s.Replace('a', 'o');
                    s.Replace('a', 'o');
                }
            }
            // s = s.Remove(20, s.Length - 20);
            s.Remove(20, s.Length - 20);
            long end = DateTime.Now.Ticks;

            Console.WriteLine("s: {0}, delay time: {1}", s, end - start);
        }
    }
}
