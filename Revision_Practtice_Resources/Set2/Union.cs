using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Set2
{//2. Implement a Union() function that takes two linked lists and returns
 //a single linked list that contains all unique elements from both linked lists.
    internal class Union
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
            public void Union(Node first, Node second)
            {//We would be always adding nodes from the second list to the first list
             //If second node head data is more than first one exhange it
                if (Convert.ToInt32(first.next.data.ToString())>Convert.ToInt32(second.data.ToString()))
                {
                    Node t = first;
                    first = second;
                    second = t;
                    Count++;
                }
                Count++;
                head = first;//Assign head to first node
                //We need to assign head to first because first will continuosly be
                //changing and so we want to store the beginning of list in head.
                while ((first.next != null) && (second != null))
                {
                    if (Convert.ToInt32(first.next.data.ToString())<Convert.ToInt32(second.data.ToString()))
                    {
                        first = first.next; //iterate over the first node
                        Count++;
                    }
                    else
                    {
                        Node n = first.next;
                        Node t = second.next;
                        first.next = second;
                        second.next = n;
                        first = first.next;
                        second = t;
                        Count++;
                    }
                }
                if (first.next == null)//means there are still some elements in second
                {
                    first.next = second;
                    Count++;
                }
                Count++;
            }
            public void bubbleSort()    //sorts singly linkedlist in ascending order
            {
                if (head == null)   //check if list is empty 
                    return;
                for (int i = 0; i < Count; i++) //loop function
                {
                    Node current = head;
                    Node chase = head;
                    Node temp;
                    while (chase.next != null)  //chase is front node 
                    {
                        while (current.next != null)    //current is running node
                        {
                            if (chase.data > current.next.data)   //compare node if greater than current node
                            {
                                temp = current.next; //store smaller node.data in temp
                                current.next = current.next.next; //connect nodes back together
                                temp.next = head;   //store smaller node as head of list
                                head = temp;
                            }
                            if (current.next == null)
                            {
                                break;
                            }
                            if (chase.data <= current.next.data)
                            {
                                current = current.next; //progress current to next node
                            }
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
                {
                    return;
                }
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
            LinkedList MyList2 = new LinkedList();
            LinkedList list = new LinkedList();
            Console.WriteLine("Please input values to the list: \nPress [Return]x2 to exit.");
            Boolean keep = true;
            while (keep == true)
            {
                MyList.UserInput();  //calls user input function
                while (method != string.Empty)
                {
                    MyList.AddSingle();    //calls add function to insert user input into node
                    MyList.UserInput();
                }
                keep = false;
            }
            Console.WriteLine("Please input values to the list: \nPress [Return]x2 to exit.");
            Boolean stay = true;
            while (stay == true)
            {
                MyList2.UserInput();  //calls user input function
                while (method != string.Empty)
                {
                    MyList2.AddSingle();    //calls add function to insert user input into node
                    MyList2.UserInput();
                }
                stay = false;
            }
            Console.Write("\nFirst list: "); MyList.PrintList();
            Console.Write("\nSecond list: "); MyList2.PrintList();
            list.Union(MyList.head, MyList2.head);
            list.Removeduplicate();
            Console.Write("\nCombined list with duplicates removed: "); list.PrintList();
        }*/
    }
}
