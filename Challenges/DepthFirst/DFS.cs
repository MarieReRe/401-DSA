using DataStructures.GraphImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.DepthFirst
{
    public class DFS
    {
        public static List<int> DepthFirst(Graph<int> graph, int root)
        {


            if (graph is null) return null;
            if (graph.Size() < 1) return null;
            if (graph.GetNeighbors(root) is null) return null;

            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();

            stack.Push(root);
            while (stack.TryPop(out int node))
            {
                if (!visited.ContainsKey(node))
                {
                    result.Add(node);
                    visited.Add(node, true);

                    if (graph.GetNeighbors(node).Keys.Count < 1) continue;
                    foreach (int neighbor in graph.GetNeighbors(node).Keys)
                    {
                        if (!visited.ContainsKey(neighbor))
                            stack.Push(neighbor);
                    }
                }
            }

            return result;

        }
    }
}
