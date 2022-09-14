using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Xml.Linq;

namespace Set2
{//3. Implement int findHeight(Node* rootNode), which takes a binary search tree and returns its height.
 //The height of a tree is equal to the number of edges between the root node and the lowest node.
    internal class TreeHeight
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
        public TreeHeight()
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
        public static void Main(string[] args)
        {
            int input;
            TreeHeight tree = new TreeHeight();
            Console.WriteLine("Please enter numbers you would like stored in the binary tree");       //user input    
            for (int i = 0; i < 10; i++)
            {
                string method = Console.ReadLine();
                if (!Int32.TryParse(method, out input))                 //exception handling
                {
                    Console.WriteLine("Incorrect input, please try again");
                }
                tree.insert(input);          //insert user input into binary tree
            }   //print the BST height 
            Console.WriteLine("\nThe height of the selected Binary tree is: "+tree.maxDepth(tree.root));

        }
    }
}
