using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181206.LinkedList
{
    class ListIterator
    {
        ListNode ptr;

        public ListIterator(ListNode head)
        {
            ptr = head;
        }

        public bool hasNext()
        {
            if (ptr == null) { return false; }
            return true;
        }

        public int next()
        {
            int data = ptr.getData();
            ptr = ptr.getNext();
            return data;
        }
    }
}
