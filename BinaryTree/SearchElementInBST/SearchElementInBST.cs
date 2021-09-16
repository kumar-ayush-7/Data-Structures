// Search for an element in a BST with recursive and iterative method
using System;

namespace SearchElementInBST
{
    class SearchElementInBST
    {
        // creting a node class for creating nodes of the binary tree
        private class Node
        {
            public int data;
            public Node left;
            public Node Right;
            public Node(int data)
            {
                this.data = data;
                this.left = null;
                this.Right = null;
            }
        }
        // function that will recursively seach for a node
        // will return the node if found else return null
        private static Node SearchElementRecursive(Node root, int key)
        {
            if (root == null)
                return null;
            else if (key == root.data)
                return root;
            else if (key > root.data)
                return SearchElementRecursive(root.Right, key);
            else
                return SearchElementRecursive(root.left, key);

        }

        // function that will iteratively seach for a node
        // will return the node if found else return null
        private static Node SearchElementIterative(Node root, int key)
        {
            Node current = root;
            if (current == null)
                return null;
            while(current!= null)
            {
                if (key == current.data)
                    return current;
                else if (key > current.data)
                    current = current.Right;
                else
                    current = current.left;
            }
            return null;

        }
        private static Node GetNodeInstance(int data)
        {
            return new Node(data);
        }
        static void Main(string[] args)
        {
            // Initializing a root node, a left child node and a right child node.
            Node root = GetNodeInstance(5);
            Node node1 = GetNodeInstance(3);
            Node node1LC = GetNodeInstance(2);
            Node node1RC = GetNodeInstance(4);
            Node node2 = GetNodeInstance(7);
            Node node2LC = GetNodeInstance(6);
            Node node2RC = GetNodeInstance(8);
            // left child becomes the left child of the root node
            // right child becomes the right child of the root node
            root.left = node1;
            root.Right = node2;

            node1.left = node1LC;
            node1.Right = node1RC;

            node2.left = node2LC;
            node2.Right = node2RC;

            // Finally The tree looks like this:
            //            5
            //          /   \
            //         3     7
            //        / \   / \
            //       2   4 6   8
            //

            Console.WriteLine($"Recursive search for node with data: {3}");
            Node searchResult = SearchElementRecursive(root, 3);
            Console.WriteLine("Node {0}.", searchResult == null ? "not found" : "found");

            Console.WriteLine($"\nRecursive search for node with data: {45}");
            searchResult = SearchElementRecursive(root, 45);
            Console.WriteLine("Node {0}.", searchResult == null ? "not found" : "found");

            Console.WriteLine($"\nIterative search for node with data: {3}");
            searchResult = SearchElementIterative(root, 3);
            Console.WriteLine("Node {0}.", searchResult == null ? "not found" : "found");

            Console.WriteLine($"\nIterative search for node with data: {45}");
            searchResult = SearchElementIterative(root, 45);
            Console.WriteLine("Node {0}.", searchResult == null ? "not found" : "found");
        }
    }
}
