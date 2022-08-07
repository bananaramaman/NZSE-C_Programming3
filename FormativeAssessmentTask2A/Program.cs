using System;
using System.Collections;

namespace FormativeAssessmentTask2A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue que = new Queue();
            Console.WriteLine("Please enter [10] numbers Divisible by 5: ");

            for (int n = 0; n < 10; n++)
            {
                int x;
                string input = Console.ReadLine();
                if (!Int32.TryParse(input, out x))  //exception handling
                {
                    Console.WriteLine("incorrect input, please try again");
                    n--;
                }
                if (x % 5 != 0)
                {
                    Console.WriteLine("this number is not divisible by 5. Try again");
                    n--;
                }
                if (x % 5 == 0)
                {
                    que.Enqueue(x);
                }
            }
            Console.WriteLine("\nNumber of elements in Queue: {0}", que.Count);
            Console.WriteLine();
            for (int n = 0; n < 3; n++)
            {
                que.Dequeue();
            }
            Console.WriteLine("The first element in the queue is: {0}", que.Peek());
            Console.WriteLine("Total elements in the queue: {0}", que.Count);
            foreach (var Item in que)
            {
                Console.WriteLine(Item);
            }
        }
    }
}
