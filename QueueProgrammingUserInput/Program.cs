﻿using System;
using System.Collections;

namespace QueueProgrammingUserInput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (Running()){}
        }
        static bool Running()
        {
            Queue que = new Queue();
            int result;
            bool running = true;
            while (running == true)
            {
                Console.WriteLine("Please select a function: \n");
                Console.WriteLine("Enter [1] for insert (ENQUEUE)");
                Console.WriteLine("Enter [2] for delete (DEQUEUE)");
                Console.WriteLine("Enter [3] for display (PEEK)");
                Console.WriteLine("Enter [4] To exit the program");
                string method = (Console.ReadLine());
                if (!Int32.TryParse(method, out result))
                {
                    Console.WriteLine("\n*** Error - This is a numbers only field ***\n");
                    return true;
                }
                result = Convert.ToInt32(method);
                if (result > 4 || result < 1)
                {
                    Console.WriteLine("\n*** Error - Please make a valid selection ***\n");
                }
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Please input the number of elements in the queue: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        for (int n = 1; n <= input; n++)
                        {
                            que.Enqueue(n);
                        }
                        Console.WriteLine("\nNumber of elements in Queue: {0}", que.Count);
                        Console.WriteLine();
                        break;
                    case 2:
                        if (que.Count <= 0)
                        {
                            Console.WriteLine("\n*** Queue Underflow ***\n");
                            break;
                        }
                        Console.WriteLine("The Top element of queue is: {0}", que.Peek());
                        que.Dequeue();
                        Console.WriteLine("Total elements in the queue: {0}", que.Count);
                        break;
                    case 3:
                        Console.WriteLine("The first element in the queue is: {0}", que.Peek());
                        foreach (var Item in que)
                        {
                            Console.WriteLine(Item);
                        }
                        break;
                    case 4:
                        return false;
                }
            }
            return false;
        }
    }
}
