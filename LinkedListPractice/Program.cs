using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Running()) { }
        }
        static bool Running()
        {
            // Implementation of Linked List
            //Populate list with values / nodes
            LinkedList<string> listylist = new LinkedList<string>();
            listylist.AddLast("3");
            listylist.AddLast(".");
            listylist.AddLast("1");
            listylist.AddLast("4");
            listylist.AddLast("1");
            listylist.AddLast("5");
            listylist.AddLast("9");
            listylist.AddLast("2");
            listylist.AddLast("6");
            listylist.AddLast("5");
            listylist.AddLast("3");
            listylist.AddLast("5");
            listylist.AddLast("8");
            listylist.AddLast("9");
            listylist.AddLast("7");

            Console.WriteLine("Have some Pi");
            //Printing each node contained within the linked list
            foreach (string str in listylist)
            {
                Console.Write(str);
            }
            Console.WriteLine("\n");
            int result;
            bool running = true; 
            while (running == true)
            {
                Console.WriteLine("\nPlease select a function: \n");
                Console.WriteLine("Enter [1] to remove a specific node");
                Console.WriteLine("Enter [2] to remove the first node");
                Console.WriteLine("Enter [3] to remove the last node");
                Console.WriteLine("Enter [4] to clear the entire Linked list");
                Console.WriteLine("Enter [5] to check if list contains specific element");
                Console.WriteLine("Enter [6] To exit the program");
                string method = (Console.ReadLine());
                if (!Int32.TryParse(method, out result))
                {
                    Console.WriteLine("\n*** Error - This is a numbers only field ***\n");
                    return true;
                }
                result = Convert.ToInt32(method);
                if (result > 5 || result < 1)
                {
                    Console.WriteLine("\n*** Error - Please make a valid selection ***\n");
                    return true;
                }
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Choose a number from the previous list to remove: ");
                        string rem = Console.ReadLine(); 
                        listylist.Remove(rem);          //removal of user input value, from Linked List
                        foreach (string str in listylist)           //Print Linked List values
                        {
                            Console.Write(str);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Remove first Node"); 
                        listylist.RemoveFirst();        //Removal of First node in the Linked List
                        foreach (string str in listylist)
                        {
                            Console.Write(str);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Remove last Node");
                        listylist.RemoveLast();         //Removal of Last node in Linked List 
                        foreach (string str in listylist)
                        {
                            Console.Write(str);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Clear all Nodes");
                        listylist.Clear();          //Clear/removal of all nodes in the linked list
                        foreach (string str in listylist)
                        {
                            Console.Write(str);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter a value to check for in the linked list");
                        string check = Console.ReadLine();
                        if (listylist.Contains(check) == true)          //Check if linked list contains user defined value
                        {
                            Console.WriteLine("element found !!");
                        }
                        else
                            Console.WriteLine("element not found !!");
                        break;
                    case 6:
                        return false;
                }
            }
            return false;
        }
    }
}
