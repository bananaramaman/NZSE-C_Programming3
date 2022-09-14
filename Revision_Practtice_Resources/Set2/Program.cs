using System;
using System.Collections;
using System.Collections.Generic;

namespace Set2
{
    internal class Program
    {
        public static int input;
        public static string method;
        class Node
        {
            public int data;
            public Node next;
            public Node prev;
        }
        class LinkedList 
        {
            public Node head;
            public Node First
            {
                get { return head; }
            }
            public Node tail;
            public Node Last
            {
                get { return tail; }
            }
            public int Count { get; private set; }
            public void AddSingle()   //Function to add values to the list (SINIGLY LINKEDLIST)
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
            public void Add()   //AKA add last
            {
                Node newNode = new Node();
                newNode.data = input;
                if (tail == null)
                {
                    head = newNode;
                }
                else
                {   //Connect the final nodes
                    newNode.prev = tail;
                    tail.next = newNode;
                }
                tail = newNode; //set new Tail
                Count++;
            }
            public void Addfirst()
            {
                Node newNode = new Node();
                newNode.data = input;
                newNode.next = head;
                if (head == null)
                {
                    tail = newNode;
                }
                else
                {
                    head.prev = newNode;
                }
                head = newNode;
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
            }
            public void Removeduplicate()   //finds duplicate items in singly linkedlist and removes it
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
            public void UserInput() //Function for storing user input into variable
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
        }/*
        public static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            Console.WriteLine("Please input values to the list: \nPress [Return]x2 to exit.");
            MyList.UserInput();
            MyList.Addfirst();
            while (MyList.Count >= 1)
            {
                Boolean keep = true;
                while (keep == true)
                {
                    MyList.UserInput();  //calls user input function
                    if (method == string.Empty)
                    {
                        MyList.Removeduplicate();
                        MyList.PrintList();
                        return;
                    }
                    MyList.Add();    //calls add function to insert user input into node
                }
            }
        }*/
    }
}
