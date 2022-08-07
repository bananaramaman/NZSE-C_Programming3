using System;
using System.Collections;

namespace QueueProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue(); //Define the Queue = 'que'

            que.Enqueue("Hello world");
            que.Enqueue("This is a Queue");
            que.Enqueue(10.58f);
            que.Enqueue(5);
            que.Enqueue(500);

            //Queue number of elements

            Console.WriteLine("Number of elements in Queue: " + que.Count);
            Console.WriteLine();

            //Printing the actual contents of the elements in que

            /*
            Console.WriteLine("\nindividual elements in the queue: \n");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Queue elements 'Dequeue'd");
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
            */

            Console.WriteLine("Elements of Queue 'PEEK'ed: \n");
            Console.WriteLine(que.Peek()); 
            Console.WriteLine(que.Peek()); 
            Console.WriteLine(que.Peek()); 
            
            Console.WriteLine("\nNumber of elements in Queue: " + que.Count);
            
            Console.ReadLine();
        }
    }
}