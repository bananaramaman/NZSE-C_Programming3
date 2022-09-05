using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace BasicMaths
{//Write a program to find even numbers from 0 to 10.
 //Implement Unit Test on the same using the AAA syntax.
 //5 test cases as PASS and 4 test cases as FAIL
    public class EvenNumbers
    {
        int[] x;
        public int[] Even(int[] y, int[]x)
        {
            int length = y.Length;
            for (int i = 0; i < length; i++)
            {
                y[i] = i;
            }
            for(int j = 0; j < x.Length; j++)
            {
                foreach (int i in y)
                {
                    if (y[i] % 2 == 0)
                    {
                        x[j] = y[i];
                        j++;
                    }
                }
                
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            return x;
        }
        /*
        static void Main(string[] args)
        {
            //EvenNumbers run = new EvenNumbers();
            //int[] y = new int[11];
            //run.Even(y);
        }
        */
    }
}
