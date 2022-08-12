using System;
namespace FormativeAssessment3Task1B
{
    internal class Program
    {   //Write a program that searches a given key ‘x’ in a given singly linked list.
        //The function should return true if x is present in linked list and false otherwise.
        public static char input;
        public static string method;
        class Node
        {
            public char data;
            public Node next;
        }
        class LinkedList
        {
            public Node head;
            public Node tail;
            public int Count { get; private set; }
            public void Add()   //Function to add values to the list, along with linking
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
                Console.WriteLine("\nthe list contains {0} values", Count);  //prints the total amount of nodes
            }
            public void UserInput() //function handles user input and exception handling. Along with allowing user to exit loop
            {
                method = (Console.ReadLine());
                if (method == string.Empty) //if user has entered blank input, userinput loop will break.
                {
                    return;
                }
                if (!char.TryParse(method, out input))
                {
                    Console.WriteLine("\n*** Error - Check input and try again ***\n");
                    Environment.Exit(1);
                }
            }
            public void Contains()  //Function to check whether list contains a specific value.
            {
                Node runner = head;
                Console.WriteLine("\nSearching for key 'x' in current list");
                while (runner != null)
                {
                    if (input == 'x'|| input == 'X')
                    {
                        Console.WriteLine("\nArgghhh Matey! X marks the spot!");
                        return;
                    }
                    runner = runner.next;
                }
                Console.WriteLine("No x was found in the list :(");
            }
        }
        public static void Main(string[] args)
        {
            LinkedList listylist = new LinkedList();
            Console.WriteLine("Please input values to the list: \nPress [Return]x2 to exit.");
            Boolean keep = true;
            while (keep == true)
            {
                listylist.UserInput();  //calls user input function
                if (method == string.Empty)
                {
                    //listylist.PrintList();
                    keep = false;
                }
                listylist.Add();    //calls add function to insert user input into node
            }
            listylist.Contains();   //contains function call 
        }
    }
}
