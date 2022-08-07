using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedListUserInput
{
    internal class Program
    {   //Define string array for storage of months to be added to Linked List
        public static string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public static int input;
        public static string info;
        class Node      //Node structure
        {
            public string data;
            public Node next;
            public Node prev;
        }
        class userInput     //UserInput method
        {
            public void UserInput()
            {
                string method = (Console.ReadLine());
                if (!Int32.TryParse(method, out input) || input > 12 || input < 1 && input != 0)
                {
                    Console.WriteLine("\n*** Error - Check input and try again ***\n");
                    return;
                }
                if (input == 0)
                {
                    return;
                }
                info = months[input - 1];
            }
        }
        class LinkedList : IEnumerable<Node>        //Linked List Creator
        {
            private Node head;  
            public Node First
            {
                get { return head; }
            }
            private Node tail;
            public Node Last
            {
                get { return tail; }
            }
            public int count { get; private set; }
            public IEnumerator<Node> GetEnumerator()    //defining enumerator for looping through linked list
            {
                Node current = head;
                while (current != null)
                {
                    yield return current;
                    current = current.next;
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
            public IEnumerable GetEnumeratorReverse()
            {
                Node current = tail;
                while (current != null)
                {
                    yield return current;
                    current = current.prev;
                }
            }
            public void Add(string info)        //method for adding nodes into linked List
            {
                userInput x = new userInput();
                x.UserInput();
                Node newNode = new Node();
                newNode.data = info;
                if (tail == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.prev = tail;
                    tail.next = newNode;
                }
                tail = newNode;
                count++;
            }
            public void AddFirst(string info)
            {
                userInput x = new userInput();
                x.UserInput();
                Node newNode = new Node();
                newNode.data = info;
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
                count++;
            }   //Method for adding the 'head' or first node in linked List
            public void PrintList()
            {
                Node runner = head;
                Console.WriteLine("\nList contains the following Nodes: ");
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }       //Method for printing all node data in linked list
        }
        public static void Main(string[] args) 
        {
            LinkedList MyList = new LinkedList();           //create an empty LinkedList
            Console.WriteLine("Please enter any amount of numbers from [1 - 12] press [0] when finished: ");
            if (MyList.count <= 0)      //Initiate addfirst method
            {
                MyList.AddFirst(info);
            }
            while (input != 0)      //initiate add method for further nodes
            {
                MyList.Add(info);
                if (input == 0)     //user defined print list and exit program
                {
                    MyList.PrintList();
                }
            }
        }
    }
}
