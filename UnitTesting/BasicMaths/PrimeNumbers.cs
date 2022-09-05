using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace BasicMaths
{//Write  a program to find the prime numbers from a 0 to 10.
 //[Prime number is a number that is divisible only by itself and 1 (e.g. 2, 3, 5, 7)]
 //Implement Unit Test on the same using the AAA syntax
 //4 test cases as PASS and 4 test cases as FAIL
    public class PrimeNumbers
    {
        int[] x = new int[4];
        public int[] Prime(int y)
        {
            int j = 0;
            int i = 1;
            while (y > 0)
            {
                if (y == 6 * i - 1 || y == 6 * i + 1 || y == 2 || y == 3)
                {
                    x[j] = y;
                    j++;
                }
                y--;
            }
            foreach (var n in x)
            {
                Console.WriteLine(n);
            }
            return x;
        }
        static void Main(string[] args)
        {
            /*PrimeNumbers run = new PrimeNumbers();
            int y = 10;
            run.Prime(y);*/
        }
    }
}
