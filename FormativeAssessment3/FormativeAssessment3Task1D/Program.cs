﻿using System;
namespace FormativeAssessment3Task1D
{
    internal class Program
    {   //Write a program that takes a list value from the user and deletes any duplicate nodes from the list. The list is not sorted. 
        //For example if the linked list is 12->11->12->21->41->43->21 then the program should convert the list to 12->11->21->41->43.
        public static int input;
        public static string method;
        class Node
        {
            public int data;
            public Node next;
        }
        class LinkedList
        {
            public Node head;
            public Node tail;
            public int Count { get; private set; }
            public void Add()   //Function to add values to the list, along with linking
            {
                Node newNode = new Node();
                newNode.data = input;
                if (tail == null)
                {
                    head = newNode;
                }
                else
                {
                    tail.next = newNode;    //Connect the nodes
                }
                tail = newNode; //set new Tail
                Count++;
            }
            public void RemoveDuplicate()   //finds duplicate items in the list and removes it
            {
                if (head == null)   //check if list is empty 
                    return;
                for (int i = 0; i < Count; i++) //loop for flushing repeat nodes
                {
                    if (head.data == head.next.data)    //if first node is eqaul to second, remove second node, and join first with third (now second)
                    {
                        head = head.next;
                        Count--;
                    }
                    Node chase = head;
                    Node current = head;
                    while (chase.next != null)  //chase is front node 
                    {
                        while (current.next != null)    //current is running node
                        {
                            if (chase.data == current.next.data)    //compare front node(chase) with running node(current)
                            {
                                current.next = current.next.next;
                                Count--;
                            }
                            if (current.next == null)
                            {
                                break;
                            }
                            current = current.next; //progress current to next node
                        }
                        if (chase.next == null)
                        {
                            break;
                        }
                        chase = chase.next; //progress chase node to next node
                        current = chase;    //return current node to front position
                    }
                }
                return;
            }
            public void PrintList() //prints the data contained in each node in the list
            {
                Node runner = head;
                Console.WriteLine("\nList contains the following Nodes: ");
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
                Console.WriteLine("\nthe list contains {0} values", Count);  //prints the total amount of nodes
            }
            public void UserInput() //function handles user input and exception handling. Along with allowing user to exit loop
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
            }
        }
        public static void Main(string[] args)
        {
            LinkedList listylist = new LinkedList();
            Console.WriteLine("Please input values to the list: \nPress [Return]x2 to exit.");
            Boolean keep = true;
            while (keep == true)
            {
                listylist.UserInput();  //calls user input function
                if (method == string.Empty)
                {
                    listylist.RemoveDuplicate(); //calling remove function to cycle through nodes
                    listylist.PrintList();
                    return;
                }
                listylist.Add();    //calls add function to insert user input into node
            }
        }
    }
}