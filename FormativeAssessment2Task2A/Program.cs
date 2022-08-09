using System;

namespace FormativeAssessment2Task2A
{
    internal class Program
    {
        // Function for fibonacci
        static int fib(int n)
        {
            // Stop condition
            if (n == 0)
                return 0;

            // Stop condition
            if (n == 1 || n == 2)
                return 1;

            // Recursion function
            else
                return (fib(n - 1) + fib(n - 2));   //Addition of the previous 2 n values to produce the next n value
        }
        static public void Main()
        {
            // Initialize variable n.
            Console.WriteLine("Please enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci series of {0} numbers is: ", n);

            // for loop to print the fibonacci series.
            for (int i = 0; i < n; i++)
            {
                Console.Write(fib(i) + " ");
            }
            Console.ReadLine();
        }
    }
}
