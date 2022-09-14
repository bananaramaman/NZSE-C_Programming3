using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set1
{// 3. Implement int findMin(Node* rootNode), which takes a binary search tree and returns the lowest value within the tree.
 // Remember: Nodes in the left subtree of a current node will always be lower, while the right subtree will always be greater.
    internal class BinarySearchTree
    {
        // Class containing left and right child of current node and key value
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        //Root of BST
        Node root;
        //Constructor
        public BinarySearchTree()
        {
            root = null;
        }
        //This method mainly calls insertRec()
        public void insert(int key)
        {
            root = insertRec(root, key);
        }
        //A recursive function to Find a new key in BST
        Node insertRec(Node root, int key)
        {
            //If the tree is empty, return a new node
            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            //Otherwise, recur down the tree
            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);
            return root;
        }
        public void search()
        {
            searchRec(root);
        }
        //A recursive function to find the lowest value in the BST
        public void searchRec(Node root)
        {
            //If the tree is empty, return null
            while (root != null)
            {
                int temp = root.key;    //traverse through the left hand nodes.
                root = root.left;
                if (root == null)
                {
                    Console.Write("\nthe smallest value in the tree is: ");
                    Console.Write(temp);
                }
            }
        }
        //Driver Code
        public void FindMin()
        {
            int input;
            BinarySearchTree tree = new BinarySearchTree();
            Console.WriteLine("Please enter numbers you would like stored in the binary tree");       //user input    
            for (int i = 0; i < 10; i++)
            {
                string method = Console.ReadLine();
                if (!Int32.TryParse(method, out input))                 //exception handling
                {
                    Console.WriteLine("Incorrect input, please try again");
                }
                tree.insert(input);          //insert user input into binary tree
            }
            tree.search();
        }
    }
}
