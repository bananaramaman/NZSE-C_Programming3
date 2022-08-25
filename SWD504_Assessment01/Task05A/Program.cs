using System;

namespace Task05A
{   //five input numbers between 1 to 14 from the user
    //and generate a Fibonacci sequence for each of the input number and then combine in a sequence
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
                //Console.WriteLine("\nList contains the following Nodes: ");
                while (runner != null)
                {
                    Console.Write(runner.data + " ");
                    runner = runner.next;
                }
            }
            public void Fib()
            {
                Node n = head;
                int x; int i = 0; int j = 0;
                while (n != null)
                {
                    int[] array = new int[n.data+1];
                    while ( i < n.data)
                    {
                        // Stop condition
                        if (i == 0)
                        {
                            array[j] = 0;
                        }
                        // Stop condition
                        if (i == 1 || i == 2)
                        {
                            array[j] = 1;
                        }
                        // Recursion function
                        else if (i > 2)
                        {
                            array[j] = ((array[j-1])+ (array[j-2]));  //Addition of the previous 2 n values to produce the next n value
                        }
                        i++; j++;
                    }
                    i = 0; j = 0;x = 0;
                    while (x < n.data)
                    {
                        Console.Write(array[x] + " ");
                        x++;
                    }
                    n = n.next;
                }
            }
            public void UserInput() //Function for storing user input into variable
            {
                method = (Console.ReadLine());
                if (!Int32.TryParse(method, out input) || input < 1 || input > 14)
                {
                    Console.WriteLine("\n*** Error - Check input and try again ***\n");
                    Environment.Exit(1);
                }
            }
        }
        public static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            Console.WriteLine("Please enter an 5 integers between 1 - 14");
            while (true)
            {
                MyList.UserInput();  //calls user input function
                MyList.Add();    //calls add function to insert user input into node
                if (MyList.Count >= 5)
                {
                    Console.Write("Fibonacci series of ");
                    MyList.PrintList();
                    Console.Write(" numbers is: \n");
                    MyList.Fib();
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}