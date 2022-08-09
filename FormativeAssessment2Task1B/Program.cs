using System;
using System.Collections.Generic;

namespace FormativeAssessment2Task1B
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
            public void Reverse(int input) //checks if the item exists in the list
            {
                Node temp = null;                   //eg. list:  null<|1|>2,  1<|2|>3,   2<|3|>null                                   
                Node current = head;                //eg. current = 1
                while (current != null)
                {                                   //        <---prev---- Node ----next--->
                    temp = current.prev;            //eg. null<|1|>2      1<|2|>3      2<|3|>null
                    current.prev = current.next;    //eg.    2<|1|>       3<|2|>    null<|3|>
                    current.next = temp;            //eg.    2<|1|>null   3<|2|>1   null<|3|>2
                    current = current.prev;         //eg.    2<|1|>null   3<|2|>1   null<|3|>2
                }
                if (temp != null)  
                {
                    head = temp.prev;
                }
                Console.WriteLine("\nYour list has been reversed.");
            }
        }
        public static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            var value = new List<int>();
            Console.WriteLine("LIST ONE - Please enter [5] integer numbers from 1 - 10 : ");
            userInput x = new userInput();
            x.UserInput();
            MyList.Addfirst(input);
            while (MyList.Count >= 1)
            {
                MyList.Add(input);
                if (MyList.Count > 4)
                {
                    MyList.Reverse(input);
                    MyList.PrintList();
                }
            }
        }   //linkedlistNode<int> list1 = new LinkedList<int>();        //C# Canned LinkedList Method
            //LinkedListNode<int> List1Current = List1.First;
    }
}