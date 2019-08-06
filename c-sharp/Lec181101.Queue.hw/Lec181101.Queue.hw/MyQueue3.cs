using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181101.Queue.hw
{
    class Queue
    {
        class Node
        {
            private int data;
            private Node next;

            public Node()
                : this(0)
            {
            }
            public Node(int x)
            {
                data = x;
                next = null;
            }

            // getters and setters
            public int Data
            {
                get { return data; }
                set { data = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
        }

        // fields
        static Node _head;
        static Node _front;
        static Node _rear;

        // a constructor
        public Queue()
        {
            _head = null;
            _rear = null;
            _front = null;
        }

        // functions
        public void add(int n)
        {
            if (_head == null)
            {
                // Console.WriteLine("1");
                _rear = new Node(n);
                _head = _rear;
            }
            else
            {
                // Console.WriteLine("2");
                Node new1 = new Node(n);

                _rear = _head;
                while (_rear.Next != null)
                {
                    // Console.WriteLine("3");
                    _rear = _rear.Next;
                }
                _rear.Next = new1;
            }

            _rear = _head;
            while (_rear != null)
            {
                Console.WriteLine(_rear.Data);
                _rear = _rear.Next;
            }
        }

        public int remove()
        {
            if (_head == null)
            {
                Console.WriteLine("node is empty!");
                Environment.Exit(-1);
            }

            int temp = _head.Data;
            // Console.WriteLine("333: " + temp);
            temp = _head.Data;
            _head = _head.Next;

            return temp;
        }

        public void errorCheckMsg(String msg)
        {
            Console.WriteLine("error: " + msg);
            Environment.Exit(-1);
        }

        public void print(int x)
        {
            Console.WriteLine("result: " + x);
        }
    }

    class MyQueue3
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.add(10);
            q.add(20);
            q.add(30);
            // q.add(40);

            int x = q.remove();
            q.print(x);

            x = q.remove();
            q.print(x);

            x = q.remove();
            q.print(x);
            // q.remove();

            //q.add(40);
            // q.remove();

            //q.add(50);
            //q.add(60);
            //q.add(70);
            //q.add(80);
        }
    }
}
