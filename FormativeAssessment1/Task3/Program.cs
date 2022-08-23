using System;
using System.Collections.Generic;

namespace Task3
{
    // C# program for implementation
    // of Bubble Sort
    class BubbleSort
    {
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++)
                    if (arr[j] > arr[j + 1])   // 5 vs 1
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];  // temp = 5 & arr[j] = empty
                        arr[j] = arr[j + 1]; //arr[j] = 1
                        arr[j + 1] = temp;   //arr[j+1] = 5
                    }
        }
        static void printArray(int[] arr)   // Prints the array
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void UserInput(List<int> numbersList)    //Method for user input
        {
            for (int i = 0; i < 10; i++)
            {
                int x;
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out x))  //exception handling
                {
                    Console.WriteLine("incorrect input, please try again");
                    Environment.ExitCode = 1;
                }
                else
                    numbersList.Add(x);    //populate with user input
            }
        }
        // Driver method
        public static void Main()
        {
            Console.WriteLine("Please input [10] integer numbers: ");
            var numbersList = new List<int>();  //declare List to be used input
            UserInput(numbersList);
            var arr = numbersList.ToArray();    //convert List to arrry 
            bubbleSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
    }
}