using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181101.Queue.hw
{
    class Queue
    {
        // fields
        static int MAX = 3;
        static int[] q;
        static int _front;
        static int _rear;

        // constructors
        public Queue()
            : this(MAX)
        {
        }
        public Queue(int n)
        {
            q = new int[MAX];
            _front = -1;
            _rear = -1;
        }

        // functions
        public void add(int n)
        {
            // growable array
            if (_rear + 1 == MAX)
            {
                int size = 2 * q.Length;
                int[] tempArr = new int[size];
                q.CopyTo(tempArr, 0);
                q = tempArr;
            }
            _rear++;
            q[_rear] = n;
        }

        public int remove()
        {
            if (_rear + 1 == 0) { errorCheckMsg("underflow"); }
            int temp = q[0];
            shift();
            return temp;
        }

        public void errorCheckMsg(String msg)
        {
            Console.WriteLine("error: " + msg);
            Environment.Exit(-1);
        }

        public void shift()
        {
            for (int i = 0; i < _rear; i++)
            {
                q[i] = q[i + 1];
            }
            _rear--;
        }
    }

    class MyQueue2
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.add(10);
            q.add(20);
            q.add(30);
            // q.add(40);

            q.remove();
            q.remove();
            q.remove();
            // q.remove();

            q.add(40);
            // q.remove();

            q.add(50);

            int x = q.remove();
            Console.WriteLine("remove: " + x);
        }
    }
}
