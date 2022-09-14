using System;
using System.Threading;

namespace Task4
{//Use the Arrange-Act-Assert (AAA) syntax to implement the Unit tests.
 //Write 5 tests – two that passes and three that fails.
    public class UnitTesting
    {
        double c;
        public double SumofSquareofTwoNumbers(double num1, double num2)
        {
            c = (num1 * num1) + (num2 * num2);
            Console.WriteLine(c);
            if (c > 9999999)
            {
                throw new Exception("C exceeds double limit");
            }
            return c;
        }
        static void Main(string[] args)
        {
        }
    }
}
