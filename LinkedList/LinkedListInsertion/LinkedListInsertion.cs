/*Create a new linkedlist and insert a node to
    a) Beginning of the list
    b) In between the list
    c) At the end of the list
    d) After any given node
*/
using System;

namespace LinkedListInsertion
{
    // Creating node class for a linkedlist node
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
    class LinkedListInsertion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing the list with head node");
            Node Head = GetNewNode(1);
            PrintList(Head);

            Console.WriteLine("\nInserting a new node at the beginning of the list");
            Head = InsertNodeAtBeginnning(Head, 2);
            PrintList(Head);

            Console.WriteLine("\nInserting a new node in between the list");
            Head = InsertNodeInBetween(Head, 3);
            PrintList(Head);

            Console.WriteLine("\nInserting node at the end of the list");
            Head = InsertNodeAtTheEnd(Head, 4);
            PrintList(Head);

            Console.WriteLine("\nInserting node after third node of the list");
            Head = InsertNodeAfterGivenNode(Head, 5, 3);
            PrintList(Head);

            Console.WriteLine("\nInserting node at the end if given index is out of bounds");
            Head = InsertNodeAfterGivenNode(Head, 6, 56);
            PrintList(Head);
        }

        // Inserting node at the begging of the list
        private static Node InsertNodeAtBeginnning(Node Head, int data)
        {
            Node NewHead = GetNewNode(data);
            NewHead.next = Head;
            Head.next = null;
            return NewHead;
        }

        // Inserting node in between the list
        private static Node InsertNodeInBetween(Node Head, int data)
        {
            Node newList = GetNewNode(data);
            Node ptr1 = Head;
            Node ptr2 = Head.next;
            while(ptr2.next != null && ptr2.next.next != null)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next.next;
            }
            newList.next = ptr1.next;
            ptr1.next = newList;
            return Head;
        }

        // Inserting node at the end of the list
        private static Node InsertNodeAtTheEnd(Node Head, int data)
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

        // Inserting node after any given node
        private static Node InsertNodeAfterGivenNode(Node Head, int data, int idx)
        {
            Node newList = GetNewNode(data);
            Node ptr1 = Head;
            // If given index is not available add at the end of the list
            for (int i = 0; i < idx-1 && ptr1.next!= null; i++)
            {
                ptr1 = ptr1.next;
            }
            newList.next = ptr1.next;
            ptr1.next = newList;
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

        // return a new instance of Node
        private static Node GetNewNode(int data)
        {
            return new Node(data);
        }
    }
}
