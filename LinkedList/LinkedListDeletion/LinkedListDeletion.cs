/*In a linkedlist delete a node from
    a) Beginning of the list
    b) In between the list
    c) At the end of the list
    d) any given node by the data
*/
using System;

namespace LinkedListDeletion
{
    class LinkedListDeletion
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        //Function to delete element from the beginning of the list
        private static Node DeleteFromBeginning(Node Head)
        {
            if (Head.next == null) return null;
            else
            {
                Head = Head.next;
                return Head;
            }
        }

        // Delete node from between the list
        private static Node DeleteNodeInBetween(Node Head)
        {
            Node ptr1 = Head;
            Node ptr2 = Head.next;
            while (ptr2.next != null && ptr2.next.next != null)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next.next;
            }
            ptr1.next = ptr1.next.next;
            return Head;
        }
        //Function to delete element from the end of the list
        private static Node DeleteFromEnd(Node Head)
        {
            if (Head.next == null) return null;
            else
            {
                Node ptr = Head;
                while(ptr.next.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = null;
                return Head;
            }
        }
        // Function deletes the node of linkedList for given key
        private static Node DeleteNodeByKey(Node Head, int data)
        {
            Node ptr = Head;
            while(ptr.next.data != data)
            {
                ptr = ptr.next;
            }
            if (ptr.next.data == data) ptr.next = ptr.next.next;
            return Head;
        }
        // Print the LinkedList
        private static void PrintList(Node Head)
        {
            Node ptr = Head;
            do
            {
                Console.Write($"{ptr.data} ");
                ptr = ptr.next;
            }
            while (ptr != null);
        }
        // Function takes head of the linked list and adds new node to the end
        public static Node InsertNode(Node Head, int data)
        {
            Node newList = GetNewNode(data);
            Node ptr1 = Head;
            while (ptr1.next != null)
            {
                ptr1 = ptr1.next;
            }
            ptr1.next = newList;
            return Head;
        }
        static void Main(string[] args)
        {
            Node Head = GetNewNode(1);
            Head = InsertNode(Head, 2);
            Head = InsertNode(Head, 3);
            Head = InsertNode(Head, 4);
            Head = InsertNode(Head, 6);
            Head = InsertNode(Head, 7);
            Head = InsertNode(Head, 8);

            Console.WriteLine("Initial LinkedList: ");
            PrintList(Head);

            Console.WriteLine("\nDelete node from the beginning: ");
            Head = DeleteFromBeginning(Head);
            PrintList(Head);

            Console.WriteLine("\nDelete node from middle: ");
            Head = DeleteNodeInBetween(Head);
            PrintList(Head);

            Console.WriteLine("\nDelete node from end: ");
            Head = DeleteFromEnd(Head);
            PrintList(Head);

            Console.WriteLine("\nDelete node by key, data:4 ");
            Head = DeleteNodeByKey(Head, 4);
            PrintList(Head);
        }
        // return a new instance of Node
        private static Node GetNewNode(int data)
        {
            return new Node(data);
        }
    }
}
