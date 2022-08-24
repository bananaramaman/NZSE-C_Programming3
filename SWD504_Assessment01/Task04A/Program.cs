using System;
using System.Collections.Generic;

namespace Task04A
{   //Comparing two doubly linked lists are identical or not
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
            public bool Contains(List<int> value) //Adds list values to value list 
            {
                Node current = head;
                while (current != null)
                {
                    value.Add(current.data);
                    current = current.next;
                }
                return true;
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
        }
        public static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            var value = new List<int>();
            Console.WriteLine("LIST ONE - Please enter integer numbers from 1 - 10 : ");
            MyList.UserInput();
            MyList.Addfirst();
            if (MyList.Count >= 1)
            {
                MyList.UserInput();  //calls user input function
                while (method != string.Empty)
                {
                    MyList.Add();    //calls add function to insert user input into node
                    MyList.UserInput();  //calls user input function
                }
                MyList.Contains(value);
            }
            LinkedList MyList2 = new LinkedList();
            Console.WriteLine("\nLIST TWO - Please enter integer numbers from 1 - 10 : ");
            MyList2.UserInput();
            MyList2.Addfirst();
            if (MyList2.Count >= 1)
            {
                MyList2.UserInput(); 
                while (method != string.Empty)
                {
                    MyList2.Add();    
                    MyList2.UserInput();  
                }
                MyList2.Contains(value);
            }
            int g = 0; int i; int length = MyList.Count;    //checks that list 1 and 2 are of equal value and position
            for (i = 0; i < length; i++)
            {
                if (value[i] == value[length+i])
                {
                    g++;
                    if (g == length)
                    {
                        Console.WriteLine("\nLists ONE & TWO are identical");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine("\nThese lists are not the same!");
            Console.ReadLine();
        }
    }
}