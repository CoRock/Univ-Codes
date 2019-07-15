using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181206.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();

            if (l.isEmpty())
            {
                Console.WriteLine("Empty");
            }

            l.addLast(5);
            l.addLast(8);
            l.addLast(6);
            l.addFirst(1);
            l.addFirst(7);
            Console.WriteLine(l);
            Console.WriteLine("Size: " + l.getSize());

            l.add(2, 100);
            l.add(4, 1000);
            Console.WriteLine(l);

            l.remove(100);
            l.remove(6);
            l.remove(2000);
            Console.WriteLine(l);

            ListIterator i = l.listIterator();
            while (i.hasNext())
            {
                int data = i.next();
                Console.WriteLine("Traversing: " + data);
            }
        }
    }
}
