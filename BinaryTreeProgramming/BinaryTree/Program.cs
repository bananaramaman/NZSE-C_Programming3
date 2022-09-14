using System;

namespace BinaryTreeProgrramming
{
    /* Class containing left and right child of current node and key value*/
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    class BinaryTree
    {
        // Root of Binary Tree
        Node root;
        BinaryTree()
        {
            root = null;
        }
        /* Given a binary tree, print 
        its nodes in postorder*/
        void printPostorder(Node node)  //[L-R-N]
        {
            if (node == null)
                return;

            // first recur on left subtree
            printPostorder(node.left);

            // then recur on right subtree
            printPostorder(node.right);

            // now deal with the node
            Console.Write(node.key + " ");
        }
        /* Given a binary tree, print
        its nodes in inorder*/
        void printInorder(Node node)    //[L-N-R]
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.Write(node.key + " ");

            /* now recur on right child */
            printInorder(node.right);
        }
        /* Given a binary tree, print
        its nodes in preorder*/
        void printPreorder(Node node)   //[N-L-R]
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.key + " ");

            /* then recur on left subtree */
            printPreorder(node.left);

            /* now recur on right subtree */
            printPreorder(node.right);
        }
        // Wrappers over above recursive functions
        void printPostorder() //method for root node according to Postorder method furthest left first (4) then left right (5)

        {
            printPostorder(root);
        }
        void printInorder() //method for root node according to Postorder method furthest left first (4) then key node (2)
        {
            printInorder(root);
        }
        void printPreorder() //method for root node according to Postorder method key node first (1) then left (2)
        {
            printPreorder(root);
        }
        // Driver Code
        static public void Main(String[] args)
        {
            BinaryTree tree = new BinaryTree(); //defining the Binary tree
            tree.root = new Node(1);    //defining the Root Node 
            tree.root.left = new Node(2);   //define left child node
            tree.root.right = new Node(3);  //defining right child node
            tree.root.left.left = new Node(4);  //defining left left leaf Node
            tree.root.left.right = new Node(5); //defining left right leaf Node
            tree.root.right.left = new Node(6); //defining right left leaf node
            tree.root.right.right = new Node(7);    //defining right right Leaf Node

            Console.WriteLine("Preorder traversal "
                            + "of binary tree is ");
            tree.printPreorder();

            Console.WriteLine("\nInorder traversal "
                            + "of binary tree is ");
            tree.printInorder();

            Console.WriteLine("\nPostorder traversal "
                            + "of binary tree is ");
            tree.printPostorder();
        }
    }
}