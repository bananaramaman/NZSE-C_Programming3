using System;
using System.Collections.Generic;

namespace InClassLinkedList
{
    internal class Program
    {
        public static LinkedList<string> listylist = new LinkedList<string>();
        public static void Main(string[] args)      //while loop for program repitition
        {
            while (Running()) { }
        }
        public void PrintList()     //method to print the linked list nodes
        {
            Console.WriteLine("\nYour Linked List: \n");
            foreach (string str in listylist)
            {
                Console.WriteLine(str);
            }
        }
        public static bool Running()
        {
            Program p = new Program();
            Console.WriteLine("Please enter 10 Auckland suburb names: ");       //user input 10 nodes into linked list 
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Suburb - [{0}] = ", i + 1);
                string input = Console.ReadLine();
                listylist.AddLast(input);
            }
            p.PrintList();      //method call to print current content of linked list nodes 
            int result;
            Console.WriteLine("\nPlease select a function: \n");
            Console.WriteLine("Enter [1] to remove a specific place name");
            Console.WriteLine("Enter [2] to remove the first place name");
            Console.WriteLine("Enter [3] to remove the last place name");
            Console.WriteLine("Enter [4] to clear the entire Linked list");
            string method = (Console.ReadLine());
            if (!Int32.TryParse(method, out result) || result > 4 || result < 1)
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                return false;
            }
            switch (result)
            {
                case 1:
                    Console.Write("Choose a value from the previous list to remove: - ");
                    string rem = Console.ReadLine();
                    listylist.Remove(rem);          //removal of user input value, from Linked List
                    p.PrintList();
                    break;
                case 2:
                    Console.WriteLine("Remove first Node");
                    listylist.RemoveFirst();        //Removal of First node in the Linked List
                    p.PrintList();
                    break;
                case 3:
                    Console.WriteLine("Remove last Node");
                    listylist.RemoveLast();         //Removal of Last node in Linked List 
                    p.PrintList();
                    break;
                case 4:
                    Console.WriteLine("Clear all Nodes");
                    listylist.Clear();          //Clear/removal of all nodes in the linked list
                    break;
            }
            Console.WriteLine("\nEnter a value to check for in the linked list");
            string check = Console.ReadLine();
            if (listylist.Contains(check) == true)          //Check if linked list contains user defined value or not (if, else loop)
            {
                Console.WriteLine("Suburb is found!");
            }
            else
                Console.WriteLine("Suburb is not found !!");
            Console.WriteLine("\nEnter [1] to add more values to the list");        //user input return to program start, or exit program
            Console.WriteLine("Enter [2] to exit the program");
            method = (Console.ReadLine());
            if (!Int32.TryParse(method, out result) || result > 2 || result < 1)
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                return false;
            }
            switch (result)
            {
                case 1:
                    return true;
                case 2:
                    return false;
            }
            return false;
        }
    }
}