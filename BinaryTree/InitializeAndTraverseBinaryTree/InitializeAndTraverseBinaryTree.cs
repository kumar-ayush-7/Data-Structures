/* Initialize a binary tree with a root node, a left child and a right child.
 * Print preorder, inorder and postorder traversel of the initialized tree.
 */
using System;

namespace InitializeAndTraverseBinaryTree
{
    class InitializeAndTraverseBinaryTree
    {
        // creting a node class for creating nodes of the binary tree
        public class Node
        {
            public string data;
            public Node left;
            public Node Right;
            public Node(string data)
            {
                this.data = data;
                this.left = null;
                this.Right = null;
            }
        }

        // Function for preorder traversal
        private static void PrintPreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.Write($" {root.data} ->");
                PrintInOrderTraversal(root.left);
                PrintInOrderTraversal(root.Right);
            }
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

        // Function for postorder traversal
        private static void PrintPostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PrintInOrderTraversal(root.left);
                PrintInOrderTraversal(root.Right);
                Console.Write($" {root.data} ->");
            }
        }
        private static Node GetNodeInstance(string data)
        {
            return new Node(data);
        }
        
        static void Main(string[] args)
        {
            // Initializing a root node, a left child node and a right child node.
            Node root = GetNodeInstance("Root");
            Node node1 = GetNodeInstance("LeftChild");
            Node node2 = GetNodeInstance("RightChild");
            // left child becomes the left child of the root node
            // right child becomes the right child of the root node
            root.left = node1;
            root.Right = node2;

            // Finally The tree looks like this:
            //          Root
            //          / \
            //  LeftChild  RightChild
            //

            Console.WriteLine("PreOrderTraversal: ");
            PrintPreOrderTraversal(root);

            Console.WriteLine("\n\nInOrderTraversal: ");
            PrintInOrderTraversal(root);

            Console.WriteLine("\n\nPostOrderTraversal: ");
            PrintPostOrderTraversal(root);

        }
    }
}
