// Morris traversal for binary tree, time complexity O(n) space complexity(1)
using System;

namespace MorrisBSTTraversal
{
    class MorrisBSTTraversal
    {
        // creting a node class for creating nodes of the binary tree
        public class Node
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
        // Function that will do inorder traversal of BST using morris algorithm
        private static void MorrisInOrderTraversal(Node root)
        {
            Node current = root;
            // loop till current becomes null, i.e. till last node is traversed
            while (current != null)
            {
                // if there is no left sub tree log current node and move to right sub tree
                if(current.left == null)
                {
                    Console.Write($"{current.data} -> ");
                    current = current.Right;
                }
                else
                {
                    // find predecessor to the current node
                    Node predecessor = current.left;
                    while(predecessor.Right != null && predecessor.Right != current)
                    {
                        predecessor = predecessor.Right;
                    }
                    // if the predecessor is traverserd first time link it to the current,
                    // move current to current's left
                    if (predecessor.Right == null)
                    {
                        predecessor.Right = current;
                        current = current.left;
                    }
                    // if the predecessor is already linked to current, remove the link
                    // log current node and move to the right
                    else
                    {
                        predecessor.Right = null;
                        Console.Write($"{current.data} -> ");
                        current = current.Right;
                    }
                }
            }
        }

        // Function that will do preorder traversal of BST using morris algorithm
        private static void MorrisPreOrderTraversal(Node root)
        {
            Node current = root;
            // loop till current becomes null, i.e. till last node is traversed
            while (current != null)
            {
                // if there is no left sub tree log current node and move to right sub tree
                if (current.left == null)
                {
                    Console.Write($"{current.data} -> ");
                    current = current.Right;
                }
                else
                {
                    // find predecessor to the current node
                    Node predecessor = current.left;
                    while (predecessor.Right != null && predecessor.Right != current)
                    {
                        predecessor = predecessor.Right;
                    }
                    // if the predecessor is traverserd first time link it to the current,
                    // log current node and move current to current's left
                    if (predecessor.Right == null)
                    {
                        predecessor.Right = current;
                        Console.Write($"{current.data} -> ");
                        current = current.left;
                    }
                    // if the predecessor is already linked to current, remove the link
                    // move to the right
                    else
                    {
                        predecessor.Right = null;
                        current = current.Right;
                    }
                }
            }
        }

        // Function that will do postorder traversal of BST using morris algorithm
        private static void MorrisPostorderTraversal(Node root)
        {
            // Making our tree left subtree of a dummy Node
            Node dummyRoot = GetNodeInstance(0); ;
            dummyRoot.left = root;

            // Think of current as the current node 
            Node current = dummyRoot, predecessor, first, middle, last;
            while (current != null)
            {
                if (current.left == null)
                {
                    current = current.Right;
                }
                else
                {
                    /* current has a left child => it also has a predeccessor
                       make current as right child predeccessor of current    
                    */
                    predecessor = current.left;
                    while (predecessor.Right != null && predecessor.Right != current)
                    {
                        predecessor = predecessor.Right;
                    }

                    if (predecessor.Right == null)
                    {

                        // predeccessor found for first time
                        // modify the tree

                        predecessor.Right = current;
                        current = current.left;

                    }
                    else
                    {

                        // predeccessor found second time
                        // reverse the right references in chain from predecessor to current
                        first = current;
                        middle = current.left;
                        while (middle != current)
                        {
                            last = middle.Right;
                            middle.Right = first;
                            first = middle;
                            middle = last;
                        }

                        // visit the nodes from predecessor to current
                        // again reverse the right references from predecessor to current    
                        first = current;
                        middle = predecessor;
                        while (middle != current)
                        {
                            Console.Write($"{middle.data} -> ");
                            last = middle.Right;
                            middle.Right = first;
                            first = middle;
                            middle = last;
                        }

                        // remove the predecessor to node reference to restore the tree structure
                        predecessor.Right = null;
                        current = current.Right;
                    }
                }
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

            Console.WriteLine("PreOrderTraversal: ");
            MorrisPreOrderTraversal(root);
            Console.WriteLine("\nInOrderTraversal: ");
            MorrisInOrderTraversal(root);
            Console.WriteLine("\nPostOrderTraversal: ");
            MorrisPostorderTraversal(root);
        }
    }
}
