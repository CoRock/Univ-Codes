using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181108.GenericClass
{
    class IntStack
    {
        static int MAX = 100;
        int[] s;
        int top;

        public IntStack()
        {
            s = new int[MAX];
            top = -1;
        }
        public void push(int item)
        {
            top++;
            s[top] = item;
        }
        public int pop()
        {
            top--;
            return s[top + 1];
        }
        public int peek()
        {
            return s[top];
        }
        public bool isEmpty()
        {
            if (top == -1) return true;
            return false;
        }
    }

    class DoubleStack
    {
        static int MAX = 100;
        double[] s;
        int top;

        public DoubleStack()
        {
            s = new double[MAX];
            top = -1;
        }
        public void push(double item)
        {
            top++;
            s[top] = item;
        }
        public double pop()
        {
            top--;
            return s[top + 1];
        }
        public double peek()
        {
            return s[top];
        }
        public bool isEmpty()
        {
            if (top == -1) return true;
            return false;
        }
    }

    class StringStack
    {
        static int MAX = 100;
        String[] s;
        int top;

        public StringStack()
        {
            s = new String[MAX];
            top = -1;
        }
        public void push(String item)
        {
            top++;
            s[top] = item;
        }
        public String pop()
        {
            top--;
            return s[top + 1];
        }
        public String peek()
        {
            return s[top];
        }
        public bool isEmpty()
        {
            if (top == -1) return true;
            return false;
        }
    }

    class GenericClass
    {
        static void Main(string[] args)
        {
            IntStack s1 = new IntStack();
            IntStack s2 = new IntStack();

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

            DoubleStack s3 = new DoubleStack();
            s3.push(3.4);
            s3.push(5.2);
            s3.push(234.87);
            s3.push(5.6);

            double y = s3.pop();
            Console.WriteLine("a variable y: " + y);

            StringStack s4 = new StringStack();
            s4.push("kim");
            s4.push("lee");
            s4.push("park");
            s4.push("kwon");

            String z = s4.pop();
            Console.WriteLine("a variable z: " + z);
        }
    }
}
