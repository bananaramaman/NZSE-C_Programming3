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
        void search(int Key)
        {
            searchRec(root, Key);
        }
        //A recursive function to find a key in BST
        void searchRec(Node root, int Key)
        {
            //If the tree is empty, return null
            if (root != null)
            {
                searchRec(root.left, Key);
                if (Key == root.key)
                {
                    Console.WriteLine("Key {0} is found!", Key);
                }
                searchRec(root.right, Key);
            }
            if (root == null)
            {
                Console.WriteLine("...");
            }
        }
        //This method mainly calls InorderRec()
        void inorder()
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
        //A utility function to do inorder traversal of BST
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
        //Driver Code
        public static void Main(String[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(50);    //  Let us create following BST 
            tree.insert(30);    //         50
            tree.insert(20);    //       /    \
            tree.insert(40);    //      30    70
            tree.insert(70);    //      / \   / \
            tree.insert(60);    //     20 40 60 80 
            tree.insert(80);

            Console.WriteLine("please make a selection for how you would like to traverse the Binary tree: ");
            Console.WriteLine("Enter [1] for 'Inorder ' traversal");
            Console.WriteLine("Enter [2] for 'Preorder' traversal");
            Console.WriteLine("Enter [3] for 'Postrder' traversal");
            Console.WriteLine("Enter [4] to search for a specific node");

            string input = Console.ReadLine();
            if (!Int32.TryParse(input, out int value) || value < 1 || value > 4)
            {
                Console.WriteLine("\n***Error! Please make a valid selection***");
            }
            switch (value)
            {
                case 1:
                    tree.inorder();
                    break;
                case 2:
                    tree.preorder();
                    break;
                case 3:
                    tree.postorder();
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
            }
        }
    }
}