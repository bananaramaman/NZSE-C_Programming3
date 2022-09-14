using System;

namespace PetersonGraphProblem
{
    public class Peterson
    {

        // adjacency matrix.
        static bool[,] adj = new bool[10, 10];

        // resulted path - way
        static char[] result = new char[10];

        // we are applying breadth first search
        // here
        static bool findthepath(String S, int v)
        {
            result[0] = (char)(v + '0');

            for (int i = 1; i < S.Length; i++)
            {

                // first traverse the outer graph
                if (adj[v, S[i] - 'A'] || adj[S[i] - 'A', v])
                {
                    v = S[i] - 'A';
                }

                // then traverse the inner graph
                else if (adj[v, S[i] - 'A' + 5] || adj[S[i] - 'A' + 5, v])
                {
                    v = S[i] - 'A' + 5;
                }

                // if the condition failed to satisfy
                // return false
                else
                    return false;

                result[i] = (char)(v + '0');
            }
            return true;
        }
        // Driver code
        public static void Main(String[] args)
        {

            // here we have used adjacency matrix to make
            // connections between the connected nodes
            adj[0, 1] = adj[1, 2] = adj[2, 3] = adj[3, 4] = adj[4, 0] = adj[0, 5] = adj[1, 6] = adj[2, 7] =
              adj[3, 8] = adj[4, 9] = adj[5, 7] = adj[7, 9] = adj[9, 6] = adj[6, 8] = adj[8, 5] = true;

            // path to be checked
            String S = "DDB";
            if (findthepath(S, S[0] - 'A')) // findthepath(S, S[0] - 'A' + 5))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.Write("-1");
            }
        }
    }
}