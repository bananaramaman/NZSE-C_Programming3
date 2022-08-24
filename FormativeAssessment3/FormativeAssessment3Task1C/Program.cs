using System;
namespace FormativeAssessment3Task1C
{
    internal class Program
    {   //Given a singly linked list of characters, write a program that returns true if the given list is a palindrome,
        //else false. (A palindrome list is the one which is same even if reversed i.e.ROTOR.RADAR, etc)
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
                    if (input == 'x' || input == 'X')
                    {
                        Console.WriteLine("\nArgghhh Matey! X marks the spot!");
                        return;
                    }
                    runner = runner.next;
                }
                Console.WriteLine("No x was found in the list :(");
            }
            public void Palindrome()    //Function to check if linked list is palindrome
            {
                char[] chars = new char[Count]; //declare character array
                int x = 0; int y = 0;
                Node runner = head; //define list starting point
                Console.WriteLine("\nChecking if list is palindrome ");
                while (runner != null)
                {
                    chars[x] = Convert.ToChar(runner.data);     //save list node data into char array
                    runner = runner.next;       //progress through list
                    x++;
                }
                x--;
                int length = chars.Length;
                Console.WriteLine();
                for (int i = 0; i < length; i++, x--)
                {
                    if (chars[i] != chars[x])   //check if array[first] is equal to array[last]
                    {
                        Console.Write(chars[i]);
                    }
                    else
                    {
                        Console.Write(chars[i]); y++;
                    }
                }
                if (y != length)       //print whether list is palindrome or not
                {
                    Console.WriteLine(" is not a palindrome");
                }
                else
                    Console.WriteLine(" is a palidrome");
                return;
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
                    listylist.Palindrome();   //palindrome function call 
                    return;
                }
                listylist.Add();    //calls add function to insert user input into node
            }
        }
    }
}
