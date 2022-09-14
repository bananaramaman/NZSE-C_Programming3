using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Task3
{
    internal class BinarySearch
    {//create a binary search tree, with functions that allow for insertion of nodes, and for searching a specific node value.
     //Where the program returns if found or returns -1 if not: input 50, 30, 20, 40, 70, 60, 80
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
        public BinarySearch()
        {
            root = null;
        }
        public static string method;
        public static int input;
        public static int count;
        public static int x;
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
        public int maxDepth(Node root)  //recursive solution function to return the hight of BST
        {
            if (root == null)   //if root null return 0 
                return 0;
            else
            {
                int leftHeight = maxDepth(root.left);   //initialise variable to store the value of left leaf nodes
                int rightHeight = maxDepth(root.right); //initialise variable to store the value of right leaf nodes

                if (leftHeight > rightHeight)   //find the biggest value and return
                {
                    return leftHeight + 1;
                }
                else
                {
                    return (rightHeight + 1);
                }
            }
        }
        public void search()    //A recursive function to find a key in BST
        {
            Console.Write("Please enter a number to be searched: ");
            string input1 = Console.ReadLine();
            if (!Int32.TryParse(input1, out int Key) || Key < 1)
            {
                Console.WriteLine("\n***Error! Please make a valid selection***");
            }
            searchRec(root, Key);
        }
        static void searchRec(Node root, int Key)
        {
            //If the tree is empty, return null
            if (root != null)
            {
                searchRec(root.left, Key);
                if (Key == root.key)
                {
                    Console.WriteLine("Key {0} is found!", Key);
                    return;
                }
                searchRec(root.right, Key);
                x++;
            }
            if (x >= count)
            {
                Console.WriteLine("-1");
            }
        }
        public void mSearch() //A recursive function to find the lowest value in the BST
        {
            searchMin(root);
        }
        public void searchMin(Node root)
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
        void inorder()  //A utility function to do differnt traversal methods of BST
        {
            inorderRec(root);
        }
        void preorder()
        {
            preorderRec(root);
        }
        void postorder()
        {
            postorderRec(root);
        }
        void inorderRec(Node root)  // Left - Root - Right
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }
        void preorderRec(Node root)     // Root - Left - Right
        {
            if (root != null)
            {
                Console.WriteLine(root.key);
                preorderRec(root.left);
                preorderRec(root.right);
            }
        }
        void postorderRec(Node root)    // Left - Right - Root
        {
            if (root != null)
            {
                postorderRec(root.left);
                postorderRec(root.right);
                Console.WriteLine(root.key);
            }
        }
        public void UserInput() //Function for storing user input into Binary Tree
        {
            method = (Console.ReadLine());
            if (method == string.Empty) //if user has entered blank input, userinput loop will break.
            {
                return;
            }
            if (!Int32.TryParse(method, out input))
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                Environment.Exit(1);
            }
            count++;
        }
        //Driver Code
        public static void Main(string[] args)
        {
            BinarySearch tree = new BinarySearch();
            Console.WriteLine("Please enter numbers you would like stored in the binary tree");       //user input    
            Boolean keep = true;
            while (keep == true)
            {
                while (method != string.Empty)
                {
                    tree.UserInput();
                    tree.insert(input);//insert user input into binary tree
                }
                keep = false;
            }
            tree.search();
            Console.WriteLine("\nBinary search tree printed inorder traversal: ");
            tree.inorder();
        }
    }
}
