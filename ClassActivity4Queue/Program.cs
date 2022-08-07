using System;
using System.Collections;

namespace ClassActivity4Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            Queue que2 = new Queue();
            Console.WriteLine("Please enter 10 numbers between 1 & 100");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number [{0}] = ", i + 1);
                int input = Convert.ToInt32(Console.ReadLine());
                que.Enqueue(input);
            }
            Console.WriteLine("Elements in queue {0}",que.Count);
            foreach (int item in que)
            {
                if (item % 2 != 0)
                {
                    que2.Enqueue((int)item);
                }
            }
            que.Clear();
            Console.WriteLine();
            Console.WriteLine("First element in queue: = {0}",que2.Peek());
            Console.WriteLine();
            Console.WriteLine("Total elements in que: {0}", que2.Count);
        }
    }
}
