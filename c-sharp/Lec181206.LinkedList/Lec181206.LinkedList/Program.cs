using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181206.LinkedList
{
    class ListNode
    {
        int data;
        ListNode next;

        public ListNode()
        {
            data = 0;
            next = null;
        }

        public ListNode(int x)
        {
            data = x;
            next = null;
        }

        public ListNode(int x, ListNode l)
        {
            data = x;
            next = l;
        }

        public int getData()
        {
            return data;
        }

        public void setData(int x)
        {
            data = x;
        }

        public ListNode getNext()
        {
            return next;
        }

        public void setNext(ListNode next)
        {
            this.next = next;
        }
    }   // end of class ListNode

    class LinkedList
    {
        ListNode head;
        int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void addLast(int x)
        {
            ListNode node = new ListNode(x);
            count++;

            if (head == null)
            {
                head = node;
                return;
            }
            ListNode traverse = head;

            while (traverse.getNext() != null)
            {
                traverse = traverse.getNext();
            }
            traverse.setNext(node);
        }

        public void addFirst(int x)
        {
            ListNode node = new ListNode(x, head);
            count++;
            head = node;
        }

        public override string ToString()
        {
            // traverse
            String s = "( ";
            ListNode tmp = head;
            while (tmp != null)
            {
                s = s + tmp.getData() + " ";
                tmp = tmp.getNext();
            }
            s = s + ")";

            return s;
        }

        public int getSize()
        {
            return count;
        }
    }   // end of class LinkedList

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.addLast(5);
            l.addLast(8);
            l.addLast(6);
            l.addFirst(1);
            l.addFirst(7);
            Console.WriteLine(l);
        }
    }
}
