﻿using System;
using System.Collections.Generic;

namespace Task02B
{   //linked list basic remove functions, rem first, rem last, rem specific, rem all.
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Running()) { }
        }
        static bool Running()
        {
            // Implementation of Linked List
            LinkedList<string> listylist = new LinkedList<string>();
            Console.WriteLine("Please enter [10] New Zealand place names");
            for (int i = 0; i < 10; i++)
            {
                listylist.AddLast(Console.ReadLine());
            }
            //Printing each node contained within the linked list
            Console.WriteLine("\nThank you!\nYour place name list contains the following place names");
            foreach (string str in listylist)
            {
                Console.Write("{0}, ", str);
            }
            int result;
            Console.WriteLine("\n\nPlease select a function for removal: \n");
            Console.WriteLine("Enter [1] to remove a specific place name");
            Console.WriteLine("Enter [2] to remove the first place name");
            Console.WriteLine("Enter [3] to remove the last place name");
            Console.WriteLine("Enter [4] to clear the entire place name list");
            string method = (Console.ReadLine());
            if (!Int32.TryParse(method, out result) || (result > 4 || result < 1))
            {
                Console.WriteLine("\n*** Error - Please make a valid selection ***\n");
                return false;
            }
            switch (result)
            {
                case 1:
                    Console.WriteLine("Choose a place name from the previous list to remove: ");
                    string rem = Console.ReadLine();
                    listylist.Remove(rem);          //removal of user input value, from Linked List
                    foreach (string str in listylist)           //Print Linked List values
                    {
                        Console.Write("{0}, ", str);
                    }
                    break;
                case 2:
                    Console.WriteLine("Remove first place name");
                    listylist.RemoveFirst();        //Removal of First node in the Linked List
                    foreach (string str in listylist)
                    {
                        Console.Write("{0}, ", str);
                    }
                    break;
                case 3:
                    Console.WriteLine("Remove last place name");
                    listylist.RemoveLast();         //Removal of Last node in Linked List 
                    foreach (string str in listylist)
                    {
                        Console.Write("{0}, ", str);
                    }
                    break;
                case 4:
                    Console.WriteLine("Clear all place name");
                    listylist.Clear();          //Clear/removal of all nodes in the linked list
                    foreach (string str in listylist)
                    {
                        Console.Write("{0}, ", str);
                    }
                    break;
            }
            Console.Write("\n\nDo you wish to check if a specific place name exists? [Y / N]: ");
            char option = Convert.ToChar(Console.ReadLine());
            if (option == 'y' || option == 'Y')
            {
                Console.Write("\nplease enter the place name you wish to search: ");
                string search = Console.ReadLine();
                if (listylist.Contains(search) == true)
                {
                    Console.WriteLine("\nplace name found!");
                }
                else
                    Console.WriteLine("\nNot found :(");
            }
            if (option == 'n' || option == 'N')
            {
                Console.WriteLine("\nsuit yourself...");
            }
            Console.Write("\nDo you wish to add more place names to the list? [Y / N]: ");
            char more = Convert.ToChar(Console.ReadLine());
            if (more == 'y' || more == 'Y')
            {
                Console.WriteLine("\naw s**t, here we go again!...");
                return true;
            }
            if (more == 'n' || more == 'N')
            {
                Console.WriteLine("\nThank you, Good bye");
                return false;
            }
            return false;
        }

    }
}
