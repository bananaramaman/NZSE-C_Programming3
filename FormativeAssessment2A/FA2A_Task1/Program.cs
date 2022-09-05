using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace FA2A_Task1
{
    internal class Program
    {
        public int[] pCode = new int[10];   //define postcode array
        public int code;    //temp integer
        public void Input() //storing user input into pCode array
        {
            for (int i = 0; i < pCode.Length; i++)
            {
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out code))   //Exception handling to catch non integer input
                {
                    Console.WriteLine("{0} is not a valid input", input);
                }
                pCode[i] = code;    //storing integers into pCode array 
            }
        }
        public void BubbleSort()    //Sorting function
        {
            int n = pCode.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++) //initialising for loops
                    if (pCode[j] > pCode[j + 1])    //comparing values in array
                    {
                        int temp = pCode[j];    //storing the larger value in temp array
                        pCode[j] = pCode[j + 1];    //moving the smaller value to the front of the array
                        pCode[j + 1] = temp;    //placing the larger value after the smaller.
                    }
        }
        public void Print() //Print array function
        {
            foreach (int i in pCode)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)  //Main driver code
        {
            Console.WriteLine("please enter [10] New Zealand postcodes");
            Program p = new Program();
            p.Input();
            p.BubbleSort();
            Console.WriteLine("Your Postcode array has been sorted.. You're welcome.");
            p.Print();
        }    
    }
}
