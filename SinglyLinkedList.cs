using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    
    public class Node
    {
        public int data;
        public Node next;

        public Node (int value)
        {
            data = value;
            next = null;
        }
    }
    public class SinglyLinkedList
    {
        Node head;
        
        public SinglyLinkedList()
        {
            head = null;
           
        }
        
        public void AddLast(int data)
        {
            if(head == null)
            {
                head = new Node(data);
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            
           current.next = new Node(data);
        }
        public void AddFirst(int data)
        {
            Node current = new Node(data);
            current.next = head;
            head = current;
            
        }
        
        public void PrintNode()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine("Value of a Node is {0}", current.data);
                current = current.next;
                
            }
        }

        public void AddNodeAt(int index, int data)
        {
            Node current = head;
            int count = 0;
            Node newNode = new Node(data);
            while (current != null)
            {
                if(count == index)
                {
                    newNode.next = current.next;
                    current.next = newNode;
                    return;
                }
                current = current.next;
                count++;
            }

        }

        public void GetKthNodeFromEnd(int index)
        {
            Node first = head;
            Node second = head;
            int count = 0;
            while (second.next != null)
            {
                second = second.next;
                count++;
            }
            int k = count - index;
            count = 0;
            while(first.next != null)
            {
                if(k == count)
                {
                    Console.WriteLine("The {0}th element from the end is {1}", index, first.data);
                    return;
                }

                first = first.next;
                count++;
            }
        }

        public void GetMiddleNumber()
        {
            Node current = head;
            int length = 0;
            Node middle = head;
            while (current.next != null)
            {
                length++;
                if (length % 2 == 0)
                {
                    middle = middle.next;
                }
                current = current.next;
            }
            if (length % 2 == 1)
            {
                middle = middle.next;
            }

            Console.WriteLine("The middle number is {0}", middle.data);
        }

        public void RemoveNodeAtFromHead(int index)
        {
            Node current = head;
            int counter = 0;
            Node temp = head;

            while(current.next != null)
            {
                if(index == counter)
                {
                    temp = current;
                    temp.next = current.next.next;
                    current = temp;
                }
                else
                {
                    current = current.next;

                }
                counter++;
            }
        }
    }
}
