using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList arr = new SinglyLinkedList();

            arr.AddFirst(3);
            arr.AddFirst(2);
            arr.AddFirst(5);
            arr.AddFirst(10);
            arr.AddLast(6);
            arr.AddNodeAt(2, 16);
            arr.AddLast(9);

            arr.PrintNode();

            Console.WriteLine("===============================");
            Console.WriteLine("Middle Number in List");
            arr.GetMiddleNumber();

            Console.WriteLine("===============================");
            Console.WriteLine("Kth Node from the End");
            //arr.GetKthNodeFromEnd(2);
            arr.RemoveNodeAtFromHead(2);
            arr.PrintNode();

            //DoublyLinkedList arr = new DoublyLinkedList();
            //arr.AddLast(3);
            //arr.AddLast(2);
            //arr.AddLast(5);
            //arr.AddLast(10);
            //arr.PrintNode();

            //Console.WriteLine("===============================");
            //Console.WriteLine("Reverse Linked List");
            //arr.ReverseLinkedlist();

        }

    }
   

}
