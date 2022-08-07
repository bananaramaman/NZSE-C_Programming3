using System;
using System.Collections;

namespace W1_Friday_Activity
{
    public static class ReverseStack        //Method for reversing the order of the current stack
    {  
        public static Stack Reverse(Stack st)
        {
            Stack temp = new Stack();

            while (st.Count != 0)
                temp.Push(st.Pop());

            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input; //Define new String

            Console.WriteLine("Please input a word or statement: ");   //Gather User input
            Input = Convert.ToString(Console.ReadLine()); //Convert input to string 

            Stack st = new Stack(); //Define initial stack  
            string Rev;    //Define string for reversing

            foreach (char c in Input)     //Pushes each character from user input 'Country' into the stack 'st'
            {
                st.Push(c);
            }
            Console.WriteLine("\nCurrent stack after PUSHing user input: ");    //Prints the currect characters in the stack 'st'
            foreach (char c in st)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            st = ReverseStack.Reverse(st);  //calls the reverse method
            Console.WriteLine("\nCurrent string after reversing & POPPING from stack: ");   //converts data from stack into string data type and prints
            foreach (char c in st)
            {
                Rev = Convert.ToString(c);
                Console.Write(Rev);
            }
            Console.ReadLine();
        }
    }
}
