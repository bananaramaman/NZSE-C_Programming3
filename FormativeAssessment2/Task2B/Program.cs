using System;

namespace Task2B
{
    internal class Program
    {
        // Function for Factorial
        static int fac(int n)
        {
            // Stop condition
            if (n == 0 || n == 1)
                return 1;
            // Recursion function
            else
                return (n) * fac(n - 1);   //Multiplication of the n value with the n value decremental
        }
        static public void Main()
        {
            // Initialize variable n.
            Console.WriteLine("Please enter an integer");
            int n;
            string input = (Console.ReadLine());    //Exception handling
            if (!Int32.TryParse(input, out n) || n < 0)
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                return;
            }
            Console.Write("Factorial of number {0} is: ", n);
            // Print Factorial
            Console.Write(fac(n) + " ");
            Console.ReadLine();
        }
    }
}