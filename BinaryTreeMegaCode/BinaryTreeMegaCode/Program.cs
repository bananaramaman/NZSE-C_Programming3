using System;

namespace Traversal
{
    // C# program to demonstrate insert operation in binary search tree
    class BinarySearchTree
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
        BinarySearchTree()
        {
            root = null;
        }
        public static string method;
        public static int input;
        public static int count;
        public static int x;
        //This method mainly calls insertRec()
        void insert(int key)
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
        public void searchMin(Node root) //A recursive function to find the lowest value in the BST
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
        void search(int Key)
        {
            searchRec(root, Key);
        }
        void searchRec(Node root, int Key) //A recursive function to find a key in BST
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
        public static void Main(String[] args)  //Driver Code
        {
            BinarySearchTree tree = new BinarySearchTree();
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
            Console.WriteLine("please make a selection for how you would like to traverse the Binary tree: ");
            Console.WriteLine("Enter [1] for 'Inorder ' traversal");
            Console.WriteLine("Enter [2] for 'Preorder' traversal");
            Console.WriteLine("Enter [3] for 'Postrder' traversal");
            Console.WriteLine("Enter [4] to search for a specific node");
            Console.WriteLine("Enter [5] to return Tree height");
            Console.WriteLine("Enter [6] to return minimum value");

            string opt = Console.ReadLine();
            if (!Int32.TryParse(opt, out int value) || value < 1 || value > 6)
            {
                Console.WriteLine("\n***Error! Please make a valid selection***");
            }
            switch (value)
            {
                case 1:
                    tree.printInorder();
                    break;
                case 2:
                    tree.printPreorder();
                    break;
                case 3:
                    tree.printPostorder();
                    break;
                case 4:
                    Console.Write("Please enter a number to be searched: ");
                    string input1 = Console.ReadLine();
                    if (!Int32.TryParse(input1, out int Key) || Key < 1)
                    {
                        Console.WriteLine("\n***Error! Please make a valid selection***");
                    }
                    tree.search(Key);
                    break;
                case 5:
                    Console.WriteLine("\nThe height of the selected Binary tree is: " + tree.maxDepth(tree.root));
                    break;
                case 6:
                    tree.searchMin(tree.root);
                    break;
            }
        }
    }
}