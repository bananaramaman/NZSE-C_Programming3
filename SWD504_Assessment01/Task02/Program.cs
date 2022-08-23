using System;
using System.Collections;

namespace Task02A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[10];
            int x;
            Console.WriteLine("Please input [10] numbers from 1 - 100: ");   //Gather User input
            for (int i = 0; i < input.Length; i++)
            {
                string num = Console.ReadLine();
                if (!Int32.TryParse(num, out x))    //excception handling
                {
                    Console.WriteLine("{0} is not an integer", num);
                    return;
                }
                input[i] = Convert.ToInt32(x);
            }
            Stack st = new Stack(); //Define initial stack 
            foreach (int i in input)     //Pushes each character from user input into the stack 'st'
            {
                st.Push(i);
            }
            Console.WriteLine("\nPeek current stack");
            foreach (int i in input)   //peeking all values within st stack
            {
                st.Push(i);
                Console.Write(st.Peek()+" ");
                st.Pop();
            }
            Console.WriteLine("\n\nPop all values in stack");
            while (st.Count != 0)   //popping all values in st stack 
            {
                st.Pop();
                if (st.Count == 0)  //confirming stack is empty 
                {
                    Console.WriteLine("\nStack is empty");
                }
            }
        }
    }
}