using System;
using System.Reflection;

namespace FA2A_Task2
{
/*Consider a walk W in graph G, which consists of L vertices 
 * W1, W2, …, Wn. A string S of L letters ‘A’ – ‘E’ is realized by walk W 
 * if the sequence of letters written along W is equal to S.
Vertices can be visited multiple times while walking along W.
Determine whether there is a walk W which realizes a given string S in graph G, 
and if so then find the lexicographically least such walk.
The only line of input contains one string S.
If there is no walk W which realizes S, then output -1 otherwise, 
you should output the least walk W which realizes S.
For example, S = ‘ABBECCD’ is realized by W = (0, 1, 6, 9, 7, 2, 3).*/
    internal class Program
    {   //defining the adjacency matrix
        static bool[,] adj = new bool[10, 10];
        //resulted path - way
        static char[] result = new char[10];
        //defining the breadth first search appraoach 
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
                result[i]=(char)(v + '0');
            }
            return true;
        }
        public static void Main(string[] args)  //driver code
        {   //adjacency matrix initialising the connections between nodes within the graph
            adj[0, 1] = adj[1, 2] = adj[2, 3] = adj[3, 4] = adj[4, 0] = adj[0, 5] = adj[1, 6] = adj[2, 7] =
                adj[3, 8] = adj[4, 9] = adj[5, 7] = adj[7, 9] = adj[9, 6] = adj[6, 8] = adj[8, 5] = true;
            String S = "ABBECCD";
            if (findthepath(S, S[0] - 'A') || findthepath(S, S[0]-'A'+5)) //or statement allows for nodes to be visited more than once
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
