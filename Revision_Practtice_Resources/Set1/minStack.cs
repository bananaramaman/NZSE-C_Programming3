using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set1
{
    internal class minStack
    {
        public void Min()   //function to find the minimum value in a given stack
        {
            int input;
            Stack<int> minimum = new Stack<int>();      //defining the input stack
            Stack<int> tmpStack = new Stack<int>();     //and temporary stack
            Console.WriteLine("Please enter numbers from 1 - 5");       //user input    
            for (int i = 0; i < 5; i++)
            {
                string method = Console.ReadLine();
                if (!Int32.TryParse(method, out input))                 //exception handling
                {
                    Console.WriteLine("Incorrect input, please try again");
                    Environment.Exit(-1);
                }
                minimum.Push(input);              //push user input into the stack
            }
            while (minimum.Count > 0)             //while loop to sort the stack
            {
                int temp = minimum.Pop();         //store the first value from input stack in temp variable
                while (tmpStack.Count > 0 && tmpStack.Peek() < temp)    //while temporary stack is not empty & temporary stack value is less than temp variable 
                {                                                       //push the first value from Temporary stack into the input stack
                    minimum.Push(tmpStack.Pop());       
                }
                tmpStack.Push(temp); //push the temp variable into the temporary stack, then continue loop
            }
            Console.WriteLine("The Minimum value in the stack is: {0}", tmpStack.Peek());   //show the first value in sorted temporary stack, which will be the lowest value
        }
    }
}
