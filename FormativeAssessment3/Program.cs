﻿using System;

namespace FormativeAssessment3Task1A
{
    internal class Program
    {   //Write a program to count the number of nodes in a given singly
        //linked list (i.e length of a LinkedList using Recursive and Iterative approach)
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
            public void PrintList() //prints the data contained in each node in the list
            {
                Node runner = head;
                Console.WriteLine("\nList contains the following Nodes: ");
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
                Console.WriteLine("\nthe list contains {0} values",Count);  //prints the total amount of nodes
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
                    listylist.PrintList();
                    keep = false;
                }
                listylist.Add();    //calls add function to insert user input into node
            }
        }
    }
}
