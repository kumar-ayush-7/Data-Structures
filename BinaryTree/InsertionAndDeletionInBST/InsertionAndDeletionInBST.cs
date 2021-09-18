using System;

namespace InsertionAndDeletionInBST
{
    class InsertionAndDeletionInBST
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
        /// <summary>
        /// Function to insert element in binary search tree
        /// </summary>
        /// <param name="root"></param>
        private static void InsertIntoBST(Node root, int element)
        {
            Node parent = root;
            while (root != null)
            {
                parent = root;
                if (element == root.data)
                {
                    Console.WriteLine("Cannot insert element, element already exists.");
                    return;
                }
                else if (element > root.data)
                    root = root.Right;
                else
                    root = root.left;
            }
            Node newNode = GetNodeInstance(element);
            if (element > parent.data)
                parent.Right = newNode;
            else
                parent.left = newNode;
        }

        // Function for inorder traversal
        private static void PrintInOrderTraversal(Node root)
        {
            if (root != null)
            {
                PrintInOrderTraversal(root.left);
                Console.Write($" {root.data} ->");
                PrintInOrderTraversal(root.Right);
            }
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
            PrintInOrderTraversal(root);
            int element = 25;
            Console.WriteLine($"\nInserting element {element} to BST");
            InsertIntoBST(root, element);
            PrintInOrderTraversal(root);
            element = 11;
            Console.WriteLine($"\nInserting element {element} to BST");
            InsertIntoBST(root, element);
            PrintInOrderTraversal(root);
            element = 45;
            Console.WriteLine($"\nInserting element {element} to BST");
            InsertIntoBST(root, element);
            PrintInOrderTraversal(root);
        }
    }
}
