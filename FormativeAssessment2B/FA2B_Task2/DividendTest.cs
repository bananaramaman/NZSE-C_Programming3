using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FA2B_Task2
{
    public class Dividend
    {
        int remainder;
        public int Testing(int dividend, int divisor)
        {
            remainder = dividend % divisor;
            if (remainder <= 0)
            {
                throw new Exception("WRONG!");
            }
            int quotient = dividend / divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

            return remainder;
        }
        static void Main(string[] args)
        {
            /*DividendTest test = new DividendTest();
            int dividend = 50;
            test.Testing(dividend);*/
        }
    }
}
