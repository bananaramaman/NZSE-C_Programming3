using System;
using System.Collections;

namespace StackProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Country; //Define new String

            Console.WriteLine("Please input your Country: ");   //Gather User input
            Country = Convert.ToString(Console.ReadLine()); //Convert input to string 

            char[] Chars = Country.ToCharArray();   //Define new Character array    
            Stack st = new Stack(); //Define initial stack  
            Stack Rev = new Stack();    //Define stack for reversing

            foreach (char c in Country)     //Pushes each character from user input 'Country' into the stack 'st'
            {
                st.Push(c);
            }

            Console.WriteLine("\nCurrent PUSH stack: ");    //Prints the currect characters in the stack 'st'
            foreach (char c in st)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            while (st.Count != 0)   //Reversing the current stack 'st' and outputting in new stack 'Rev'
            {
                Rev.Push(st.Pop());
            }
            Console.WriteLine("\nCurrent reversed stack: ");

            foreach (char c in Rev)     //Prints the new reversed stack
            {
                Console.Write(c);
            }
            Console.WriteLine();

            Rev.Pop();  //POP or removes 1 value for each iteration of POP
            Rev.Pop();
            Rev.Pop();

            Console.WriteLine("\nPOP 3 values, current stack:");    //Printing the current stack with Popped values removed
            foreach (char c in Rev)
            {
                Console.Write(c);
            }

            Console.WriteLine("\n");
            Console.WriteLine("First element in stack 'PEEK':" + Rev.Peek());       //Prints the first element in the stack using 'PEEK'
            
        }
    }
}
