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
    }
}
