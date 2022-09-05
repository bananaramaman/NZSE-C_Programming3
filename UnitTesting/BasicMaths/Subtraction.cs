using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMaths
{
    public class Subtraction
    {
        int c;
        public int SumTwoNumbers(int num1, int num2)
        {
            c = num1 - num2;
            if (c < 0)
            {
                throw new Exception("c is less than zero!");
            }
            else
                Console.WriteLine(c);
            return c;
        }
    }
}
