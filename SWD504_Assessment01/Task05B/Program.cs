using System;

namespace Task05B
{
    internal class Program
    {//There are n number of servers in a datacentre. A customer can choose r number of servers at a time to use where r < n.
     //By using a recursive algorithm, calculate the number of different combinations the customer could have.
     //You are required to get the user input for the number of collection(n) and selection(r).

        //nCr = n!/r!(n-r)!

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
            Console.Write("Please enter an integer number of servers (n): ");
            int n;int r; 
            string input = (Console.ReadLine());    //Exception handling
            if (!Int32.TryParse(input, out n) || n < 0)
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                return;
            }
            Console.Write("\nPlease enter an integer number of servers in use (r): ");
            string user = (Console.ReadLine());    //Exception handling
            if (!Int32.TryParse(user, out r) || r < 0 || r > n)
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                return;
            }

            // Print Factorial
            int result = fac(n) / (fac(r) * fac(n - r));
            Console.WriteLine("\nTotal combinations of server selections {0}",result);
            Console.ReadLine();
        }
    }
}
