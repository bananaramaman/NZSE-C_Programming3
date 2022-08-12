using System;
using System.Collections;


namespace ReverseStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input, define variable.
            Console.WriteLine("Please Input a phrase: \n");
            string input = Console.ReadLine();
            //convert string to char array. Define stacks
            char[] chars = input.ToCharArray();
            int length = chars.Length -1;
            Stack st = new Stack();
            Stack rev = new Stack();

            //PUSH char from array into stack
            foreach (char c in input)
            {
                st.Push(c);
            }
            //Printing each element in the stack FILO
            Console.WriteLine("\nCurrent stack: ");
            foreach (char c in st)
            {
                Console.Write(c);
            }
            //reversing the current stack by popping elements from 'st' and pushing into 'rev'
            while (st.Count != 0)
            {
                rev.Push(st.Pop());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Reversed stack: ");
            //Printing the new ordered elements in stack
            foreach (char c in rev)
            {
                Console.Write(c);
            }
            //checking if user input is a palindrome
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine();
                if (chars[i] != chars[length])
                    Console.WriteLine("\n{0} is not a palindrome", input);
                else
                    Console.WriteLine("\n{0} is a palindrome", input);
                return;
            }
            Console.ReadLine();
        }
    }
}
