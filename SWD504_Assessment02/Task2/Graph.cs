using System;

namespace Task2
{
    public class Graph
    {//Write a program to implement a Peterson Graph problem. that returns a value for all nodes visited 
        public static String S;
        //defining the adjacency matrix
        static bool[,] adj = new bool[10, 10];
        //resulted path - way
        static char[] result = new char[10];
        //defining the breadth first search appraoach 
        public void Input() //storing user input into pCode array
        {
            Console.WriteLine("Please Enter the Node path you would like to visit: ");
            S = Console.ReadLine();
        }
        static bool findthepath(String S, int v)
        {
            result[0] = (char)(v + '0');
            for (int i = 1; i < S.Length; i++)
            {       //first traverse the outer graph
                if (adj[v, S[i] - 'A'] || adj[S[i] - 'A', v])
                {
                    v = S[i] - 'A';
                }   //traverse the inner graph
                else if (adj[v, S[i] - 'A' + 5] || adj[S[i] - 'A' + 5, v])
                {
                    v = S[i] - 'A' + 5;
                }   //return false if the conditions are not satisfied
                else
                    return false;
                result[i] = (char)(v + '0');
            }
            return true;
        }
        public static void Main(string[] args)  //driver code
        {   //adjacency matrix initialising the connections between nodes within the graph
            adj[0, 1] = adj[1, 2] = adj[2, 3] = adj[3, 4] = adj[4, 0] = adj[0, 5] = adj[1, 6] = adj[2, 7] =
                adj[3, 8] = adj[4, 9] = adj[5, 7] = adj[7, 9] = adj[9, 6] = adj[6, 8] = adj[8, 5] = true;
            Graph run = new Graph();
            run.Input();
            if (findthepath(S, S[0] - 'A') /*|| findthepath(S, S[0] - 'A' + 5)*/) 
                //or statement allows for nodes to be visited more than once
            {
                Console.Write("\nHere are your results, Good Sir: ");
                Console.Write(result);
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadLine();
        }
    }
}
