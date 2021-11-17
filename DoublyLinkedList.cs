using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    internal class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
    public class DoublyLinkedList
    {
        internal DNode head;

        public void AddFirst(int value)
        {
            DNode current = new DNode(value);
            current.next = head;
            current.prev = null;
            if(head != null)
            {
                head.prev = current;
            }
            head = current;
        }

        public void AddLast(int value)
        {
            if (head == null)
            {
                head = new DNode(value);
                return;
            }
            DNode current = new DNode(value);
            DNode prevNode = head;
            while (prevNode.next != null)
            {
                prevNode = prevNode.next;
            }
            prevNode.next = current;
            current.prev = prevNode;

        }
        public void PrintNode()
        {
            DNode current = head;
            while (current != null)
            {
                Console.WriteLine("Value of a Node is {0}", current.data);
                current = current.next;

            }
        }

        public void ReverseLinkedlist()
        {
            if (head == null)
            {
                return;
            }

            DNode current = head;
            while(current.next != null)
            {
                current = current.next;

            }
            Console.WriteLine("Value of a Node is {0}", current.data);

            while (current.prev != null)
            {
                current = current.prev;
                Console.WriteLine("Value of a Node is {0}", current.data);
                
            }
        }


    }
}
