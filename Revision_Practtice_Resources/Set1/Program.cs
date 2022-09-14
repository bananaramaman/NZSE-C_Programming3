using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Set1
{   //write a function to remove even values from an Array
    internal class Program
    {
        public void removeEven(int[] Arr, int size)         //Remove even values function
        {
            for (int i = 1; i < Arr.Length; i++)            //load array with values 1-10
            {
                Arr[i] = i;
                if (Arr[i] % 2 == 0)                        //check if value is multiple of 2
                {
                    Arr[i] = 0;
                    size--;                                 //replace value with 0 and reduce size value
                }
            }
            Arr = Arr.Except(new int[] {size}).ToArray();   //Exlude 0 values from the array
            foreach (int i in Arr)
            {
                Console.WriteLine(i);                       //print modified array 
            }
            return;
        }
        static void Main(string[] args)                     //Driver code
        {
            int size = 10;
            int[] Arr = new int[size];
            //Program program = new Program();
            //program.removeEven(Arr,size);
            //minStack stack = new minStack();
            //stack.Min();
            //BinarySearchTree search = new BinarySearchTree();
            //search.FindMin();
            ShortestVerticies find = new ShortestVerticies();
            find.Verticies();

        }
    }
}
