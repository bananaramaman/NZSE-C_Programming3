using System;
using System.Collections;
using System.Collections.Generic;

namespace Task03
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
        Node root;  // Root of Binary Tree
        BinaryTree()
        {
            root = null;
        }
        /* Given a binary tree, print its nodes according to the "bottom-up" postorder traversal. */
        void printPostorder(Node node)  //[L-R-N]
        {
            if (node == null)
                return;
            printPostorder(node.left);  // first recur on left subtree
            printPostorder(node.right); // then recur on right subtree
            Console.Write(node.key + " ");  // now deal with the node
        }   /* Given a binary tree, print its nodes in inorder*/
        void printInorder(Node node)        //[L-N-R]
        {
            if (node == null)
                return;
            printInorder(node.left);    /* first recur on left child */
            Console.Write(node.key + " ");  /* then print the data of node */
            printInorder(node.right);   /* now recur on right child */
        }/* Given a binary tree, print its nodes in preorder*/
        void printPreorder(Node node)        //[N-L-R]
        {
            if (node == null)
                return;
            Console.Write(node.key + " ");  /* first print data of node */
            printPreorder(node.left);   /* then recur on left subtree */
            printPreorder(node.right);  /* now recur on right subtree */
        }
        // Wrappers over above recursive functions
        void printPostorder()
        {
            printPostorder(root);   //method for root node according to Postorder method furthest left first (4) then left right (5)
        }
        void printInorder()
        {
            printInorder(root); //method for root node according to Postorder method furthest left first (4) then key node (2)
        }
        void printPreorder()
        {
            printPreorder(root);    //method for root node according to Postorder method key node first (1) then left (2)
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

            Console.WriteLine("Inorder traversal "
                            + "of binary tree is ");
            tree.printInorder();

            Console.WriteLine("\nPreorder traversal "
                            + "of binary tree is ");
            tree.printPreorder();

            Console.WriteLine("\nPostorder traversal "
                            + "of binary tree is ");
            tree.printPostorder();
        }
    }
}