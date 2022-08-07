using System;

namespace RecursiveProgramming3
{
    public class Recursion3
    {
        static bool Natural(string input)   // Function for Natural Number
        {
            int i;
            if (int.TryParse(input, out i)) // check that value is Natural
            {
                Console.Write("\nIs the number {0} Natural? = ", i);
                return true;
            }
            else // Stop condition
            Console.Write("\nIs the number {0} Natural? = ", input);
            return false;   
        }
        static double Power(double n, double x) //function to calculate base to the power of exponent
        {
            if (x == 1) //stop condition
            {
                return n;
            }
            else
                return n * Power(n,x-1);    //Recursive function
        }
        static public void Main()
        {
            Console.Write("Please enter a number: ");     // Initialize variable n.
            double n;
            string input = (Console.ReadLine());    //Exception handling
            if (!double.TryParse(input, out n) || n < 0)
            {
                Console.WriteLine("\n*** Error - Check input and try again ***\n");
                return;
            }
            Console.Write(Natural(input));  // Implement Natural recursive function and Print Natural Number result
            Console.Write("\n\nInput an exponent for the previous value: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n{0} to the power of {1} is : ", n, x);
            Console.Write(Power(n,x));  //implement Power recursive function print results
            Console.ReadLine();
        }
    }
} 
