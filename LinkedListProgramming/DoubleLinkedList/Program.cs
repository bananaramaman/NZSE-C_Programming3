using System;

namespace DoublyLinkedList
{
    //node structure
    class Node
    {
        public string data;
        public Node next;
        public Node prev;
    }
    class LinkedList
    {
        public Node head;
        //constructor to create an empty LinkedList
        public LinkedList()
        {
            head = null;
        }
    }
    // test the code 
    class Implementation
    {
        public static void Main(string[] args)
        {
            //create an empty LinkedList
            LinkedList MyList = new LinkedList();

            //Add first node.
            Node first = new Node();   //Create an object of the Node class
            Console.WriteLine("Please enter a value for the first Node: ");
            string input = Console.ReadLine();
            first.data = input;            //Pass a value of the Node data
            first.next = null;          //Link the next to head
            first.prev = null;          //Link the prev to head
            MyList.head = first;        //head is pointing to first

            //Add second node.
            Node second = new Node();
            Console.WriteLine("Please enter a value for the second Node: ");
            string input2 = Console.ReadLine();
            second.data = input2;
            first.next = second;        //linking with first node
            second.prev = first;
            second.next = null;

            //Add third node.
            Node third = new Node();
            Console.WriteLine("Please enter a value for the third Node: ");
            string input3 = Console.ReadLine();
            third.data = input3;
            second.next = third;        //linking with second node
            third.prev = second;
            third.next = null;

            Console.WriteLine("First node:" + first.data + "\nSecond node:" + second.data + "\nThird node:" + third.data);      //Print the value of data

        }
    }
}