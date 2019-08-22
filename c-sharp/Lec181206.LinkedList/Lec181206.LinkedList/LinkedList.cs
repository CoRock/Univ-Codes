using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181206.LinkedList
{
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

        public bool isEmpty()
        {
            if (count == 0) return true;
            return false;
        }

        public bool remove(int data)
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Not removed");
                return false;
            }

            if (head != null && head.getData().Equals(data))
            {
                head = head.getNext();
                count--;
                return true;
            }

            ListNode pFollow = head;
            ListNode pTraverse = head.getNext();
            while (pTraverse != null)
            {
                if (pTraverse.getData().Equals(data))
                {
                    pFollow.setNext(pTraverse.getNext());
                    count--;
                    return true;
                }
                pFollow = pTraverse;
                pTraverse = pTraverse.getNext();
            }
            Console.WriteLine("Not removed");
            return false;
        }

        public void add(int index, int data)
        {
            if (index < 0 || index > count)
            {
                Console.WriteLine("Array out of bound error");
                return;
            }
            if (index == 0)
            {
                addFirst(data);
            }

            int n = 1;
            ListNode pFollow = head;
            ListNode pTraverse = head.getNext();

            while (pTraverse != null)
            {
                if (index == n) break;
                n++;
                pFollow = pTraverse;
                pTraverse = pTraverse.getNext();
            }
            ListNode pNode = new ListNode(data, pTraverse);
            n++;
            pFollow.setNext(pNode);
        }

        public ListIterator listIterator()
        {
            return new ListIterator(head);
        }
    }
}
