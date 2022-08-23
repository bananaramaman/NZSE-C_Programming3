using System;
using System.Collections.Generic;

namespace Task04A
{
    internal class Program
    {
        public static int input;
        class Node
        {
            public int data;
            public Node next;
            public Node prev;
        }
        class userInput
        {
            public void UserInput()
            {
                string method = (Console.ReadLine());
                if (!Int32.TryParse(method, out input) || input > 10 || input < 1)
                {
                    Console.WriteLine("\n*** Error - Check input and try again ***\n");
                    Environment.Exit(1);
                }
            }
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
            public void Add(int data)   //AKA add last
            {
                userInput x = new userInput();
                x.UserInput();
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
            public void Addfirst(int data)
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
            public bool Contains(List<int> value) //checks if the item exists in the list
            {
                Node current = head;
                while (current != null)
                {
                    value.Add(current.data);
                    current = current.next;
                }
                return false;
            }
        }
        public static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            var value = new List<int>();
            Console.WriteLine("LIST ONE - Please enter [3] integer numbers from 1 - 10 : ");
            userInput x = new userInput();
            x.UserInput();
            MyList.Addfirst(input);
            while (MyList.Count >= 1)
            {
                MyList.Add(input);
                if (MyList.Count >= 3)
                {
                    MyList.Contains(value);
                    break;
                }
            }
            LinkedList MyList2 = new LinkedList();
            Console.WriteLine("\nLIST TWO - Please enter [3] integer numbers from 1 - 10 : ");
            x.UserInput();
            MyList2.Addfirst(input);
            while (MyList2.Count >= 1)
            {
                MyList2.Add(input);
                if (MyList2.Count >= 3)
                {
                    MyList2.Contains(value);
                    break;
                }
            }
            int g = 0; int i = 0;
            while (value[i] == value[i + 3])
            {
                g++; i++;
                if (g == 3)
                {
                    Console.WriteLine("\nLists ONE & TWO are identical");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("\nThese lists are not the same!");
            Console.ReadLine();
        }
    }
}