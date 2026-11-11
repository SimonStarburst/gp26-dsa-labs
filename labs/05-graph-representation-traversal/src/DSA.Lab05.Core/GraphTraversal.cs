using System;
using System.Collections.Generic;

namespace DSA.Lab05
{
    /// <summary>
    /// Iterative graph traversals.
    ///
    /// Complete these methods after the adjacency representation is working.
    /// Think in terms of:
    /// frontier + visited + neighbors.
    /// </summary>
    public static class GraphTraversal
    {
        public static IReadOnlyList<string> BreadthFirstOrder(
            AdjacencyGraph graph,
            string start)
        {
            Queue<string> frontier = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();

            frontier.Enqueue(start);
            visited.Add(start);

            while (frontier.Count > 0)
            {
                frontier.Dequeue();
                
            }
            
            throw new NotImplementedException();
        }

        public static IReadOnlyList<string> DepthFirstOrder(
            AdjacencyGraph graph,
            string start)
        {
            throw new NotImplementedException();
        }

        public static bool IsReachableBfs(
            AdjacencyGraph graph,
            string start,
            string target)
        {
            throw new NotImplementedException();
        }
    }
}
