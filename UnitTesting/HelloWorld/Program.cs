using System;

namespace HelloWorld
{
    public class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye World!");
        }
    }
    public class UnitTest
    {
        double c;
        public double SumofSquareofTwoNumbers(double num1, double num2)
        {
            c = (num1 * num1) + (num2 * num2);
            Console.WriteLine(c);
            return c;
        }
        static void Main(string[] args)
        {
        }
    }

}
