using System;

namespace Task1
{
    internal class SortedArray
    {   //Write a program to implement a sorting function to sort postcodes stored in an array 
        public int[] pCode = new int[10];   //define postcode array
        public int code;    //temp integer
        public void Input() //storing user input into pCode array
        {
            for (int i = 0; i < pCode.Length; i++)
            {
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out code)||code < 0 || code >9999) //Exception handling to catch non integer input
                {
                    Console.WriteLine("{0} is not a valid input", input);
                    Environment.Exit(0);
                }
                pCode[i] = code;    //storing integers into pCode array 
            }
        }
        public void BubbleSort()    //Sorting function
        {
            int n = pCode.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++) //initialising for loops
                    if (pCode[j] > pCode[j + 1])//comparing values in array
                    {
                        int temp = pCode[j];     //storing the larger value in temp array
                        pCode[j] = pCode[j + 1]; //moving the smaller value to the front of the array
                        pCode[j + 1] = temp;     //placing the larger value after the smaller.
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
            SortedArray p = new SortedArray();
            p.Input();
            p.BubbleSort();
            Console.WriteLine("\nYour Postcode array has been sorted.. You're welcome.");
            p.Print();
        }
    }
}
