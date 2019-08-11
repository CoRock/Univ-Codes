using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181108.GenericClass
{
    class Stack<Type>
    {
        static int MAX = 100;
        Type[] s;
        int top;

        public Stack()
        {
            s = new Type[MAX];

            for (int i = 0; i < MAX; i++)
            {
                // int: 0 | double: 0.0 | String: null
                s[i] = default(Type);
            }
            top = -1;
        }
        public void push(Type item)
        {
            top++;
            s[top] = item;
        }
        public Type pop()
        {
            top--;
            return s[top + 1];
        }
        public Type peek()
        {
            return s[top];
        }
        public bool isEmpty()
        {
            if (top == -1) return true;
            return false;
        }
    }

    class GenericClass2
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();

            s1.push(20);
            s1.push(30);
            s1.push(40);

            int x = s1.pop();
            x = s1.pop();
            Console.WriteLine("a variable x: " + x);

            s2.push(1000);
            s2.push(2000);
            s2.push(3000);
            Console.WriteLine("s2.isEmpty(): " + s2.isEmpty());
            Console.WriteLine("s2.peek(): " + s2.peek());

            Stack<double> s3 = new Stack<double>();
            s3.push(3.4);
            s3.push(5.2);
            s3.push(234.87);
            s3.push(5.6);

            double y = s3.pop();
            Console.WriteLine("a variable y: " + y);

            Stack<String> s4 = new Stack<String>();
            s4.push("kim");
            s4.push("lee");
            s4.push("park");
            s4.push("kwon");

            String z = s4.pop();
            Console.WriteLine("a variable z: " + z);
        }
    }
}
