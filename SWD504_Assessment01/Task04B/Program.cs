﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Task04B
{   // Reversal of a doubly linked list
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
        class LinkedList : IEnumerable<Node>
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
            public IEnumerator<Node> GetEnumerator()
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
            public bool Contains(int value) //checks if the item exists in the list
            {
                Node current = head;
                while (current != null)
                {   //check if current Node data is a multiple of 2
                    if (current.data % 2 == 0)
                    {
                        return true;
                    }
                    current = current.next;
                }
                return false;
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
            public bool Remove(int value)   //finds odd or even item doubly linkedlist and removes it
            {
                Node current = head;
                while (current != null)
                {   //check if current Node data is a multiple of 2
                    if (current.data % 2 != 0)
                    {//end of the list
                        if (current.next == null)
                        {//removing the last item in the list
                            tail = current.prev;
                        }
                        else
                        {
                            current.next.prev = current.prev;
                        }
                        if (current.prev == null)
                        {//start of the list
                            head = current.next;
                        }
                        else
                        {//tie nodes back together
                            current.prev.next = current.next;
                        }
                        current = null;
                        Count--;
                        return true;
                    }
                    current = current.next;
                }
                return false;
            }
            public void Removeduplicate()   //finds an item in singly linkedlist and removes it
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
            public void Reverse() //Reverses doubly linkedlist node positions and pointers
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
                        MyList.Reverse();
                        MyList.PrintList();
                        return;
                    }
                    MyList.Add();    //calls add function to insert user input into node
                }
            }
        }
    }
}