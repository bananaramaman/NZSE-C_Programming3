using System;

namespace CircularLinkedList
{
    internal class Program
    {
        public static int input;
        public static int x = 1;
        class userinput     //user input method
        {
            public void Userinput()
            {
                Console.Write("PLease input a value for node {0}: ",x);
                input = Convert.ToInt32(Console.ReadLine());
                x++;
            }
        }
        class Node      //node structure
        {
            public int data;
            public Node next;
        }
        class LinkedList
        {
            public Node head;
            public LinkedList()      //constructor to create an empty LinkedList
            {
                head = null;
            }
            public void PrintList()         //display the content of the list
            {
                Node temp = new Node();
                temp = this.head;
                if (temp != null)
                {
                    Console.Write("\nThe list contains: ");
                    while (true)
                    {
                        Console.Write(temp.data + " ");
                        temp = temp.next;
                        if (temp == this.head)
                            break;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\nThe list is empty.");
                }
            }
        }
        class Implementation            // test the code 
        {
            static void Main(string[] args)
            {
                LinkedList MyList = new LinkedList();       //create an empty LinkedList
                Node first = new Node();                    //Add first node.
                userinput i = new userinput();
                i.Userinput();
                first.data = input;
                MyList.head = first;            //linking with head node
                first.next = MyList.head;       //linking next of the node with head

                Node second = new Node();       //Add second node.
                i.Userinput();
                second.data = input;
                first.next = second;            //linking with first node
                second.next = MyList.head;      //linking next of the node with head

                Node third = new Node();        //Add third node.
                i.Userinput();
                third.data = input;
                second.next = third;            //linking with second node
                third.next = MyList.head;       //linking next of the node with head

                MyList.PrintList();             //print the content of list
            }
        }
    }
}
