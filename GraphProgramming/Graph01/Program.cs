using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphProgramming01
{
    // This class represents a directed
    // graph using adjacency list
    // representation
    class Graph
    {
        // No. of vertices    
        private int pV;
        //Adjacency Lists
        LinkedList<int>[] adj;
        public Graph(int V)
        {
            adj = new LinkedList<int>[V];   //LinkedList<T> Class
            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new LinkedList<int>();
            }
            pV = V;
        }
        // Function to add an edge into the graph
        public void AddEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }
        // Prints BFS traversal from a given source s
        public void BFS(int s)
        {
            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[pV];
            for (int i = 0; i < pV; i++)
                visited[i] = false;

            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as
            // visited and enqueue it
            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {

                // Dequeue a vertex from queue
                // and print it
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                // Get all adjacent vertices of the
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it
                // visited and enqueue it
                LinkedList<int> list = adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

        // Driver code
        static void Main(string[] args)
        {
            Graph g = new Graph(7);

            g.AddEdge(1, 2);
            g.AddEdge(2, 1);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            g.AddEdge(3, 5);
            g.AddEdge(4, 5);
            g.AddEdge(5, 6);
            g.AddEdge(6, 6);
            g.AddEdge(6, 1);


            Console.Write("Following is Breadth First " +
                        "Traversal(starting from " +
                        "vertex 1)\n");
            g.BFS(1);
            Console.WriteLine();
            g.BFS(6);
            Console.WriteLine();
            g.BFS(2);
            Console.WriteLine();
            g.BFS(3);
        }
    }
}