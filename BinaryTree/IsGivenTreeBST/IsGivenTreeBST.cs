using System;
using System.Collections.Generic;

namespace IsGivenTreeBST
{
    class IsGivenTreeBST
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
        // Function to check if given tree is binary tree (Iterative)
        private static int IsBinary(Node root, Node prev)
        {
            prev = root;
            Stack<Node> TreeStack = new Stack<Node>();
            TreeStack.Push(prev);
            while(TreeStack.Count > 0)
            {
                prev = TreeStack.Pop();
                if (prev.left != null)
                {
                    if(prev.left.data < prev.data)
                    {
                        TreeStack.Push(prev.left);
                    }
                    else return 0;
                }
                if (prev.Right != null)
                {
                    if (prev.Right.data > prev.data)
                    {
                        TreeStack.Push(prev.Right);
                    }
                    else return 0;
                }                
            }
            return 1;
        }
        // Function to check if given tree is binary tree (Recursive method)
        //private static int IsBinary(Node root, Node prev)
        //{
        //    if(root!= null)
        //    {
        //        if (IsBinary(root.left, prev) != 1)
        //        {
        //            return 0;
        //        }
        //        if(prev != null && root.data <= prev.data)
        //        {
        //            return 0;
        //        }
        //        prev = root;
        //        return IsBinary(root.Right, prev);
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}
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

            Console.WriteLine("InOrderTraversal: ");
            PrintInOrderTraversal(root);
            Console.WriteLine("\nGiven tree is {0} binary tree.", IsBinary(root, null) == 1? "a" : "not");
        }
    }
}
