using System;
using System.Collections.Generic;
using System.Linq;

public class TopologicalSorter
{
    private Dictionary<string, List<string>> graph;
    private Dictionary<string, int> predecessorCount; // used with Iterative algorithm
    private HashSet<string> visited = new HashSet<string>(); // used with DFS algorithm
    private HashSet<string> cycleNodes = new HashSet<string>();// used with DFS algorithm for checking for cycle nodes

    public TopologicalSorter(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    // Used with DFS algorithm
    public ICollection<string> TopSort()
    {
        LinkedList<string> sorted = new LinkedList<string>();
        foreach (var node in this.graph.Keys)
        {
            //TODO: Cycle detection not working. Debug.
            //if (cycleNodes.Contains(node))
            //    throw new InvalidOperationException("Cycle detected.");
            DFS(node, sorted);
        }
        return sorted;
    }

    //Used with Iterative algorithm
    //public ICollection<string> TopSort()
    //{
    //    List<string> sorted = new List<string>();
    //    GetPredecessorCount(graph);
    //    while (true)
    //    {
    //        string nodeToRemove = predecessorCount.Keys.Where(x => predecessorCount[x] == 0).FirstOrDefault();
    //        if (nodeToRemove == null)
    //            break;

    //        foreach (var child in graph[nodeToRemove])
    //            predecessorCount[child]--;
    //        predecessorCount.Remove(nodeToRemove);
    //        graph.Remove(nodeToRemove);
    //        sorted.Add(nodeToRemove);
    //    }
    //    if (graph.Count > 0)
    //        throw new InvalidOperationException();
    //    return sorted;
    //}

    //You can select one of the two methonds below to traverse the graph
    //------------------------------------------------------------------

    //Used with Iterative algorithm
    private void GetPredecessorCount(Dictionary<string, List<string>> graph)
    {
        predecessorCount = new Dictionary<string, int>();
        foreach (var node in graph)
        {
            if (!predecessorCount.ContainsKey(node.Key))
                predecessorCount[node.Key] = 0;
            foreach (var child in node.Value)
            {
                if (!predecessorCount.ContainsKey(child))
                    predecessorCount[child] = 0;
                predecessorCount[child]++;
            }
        }
    }
    private void DFS(string node, LinkedList<string> result)
    {
        if (!visited.Contains(node))
        {
            visited.Add(node);
            cycleNodes.Add(node);
            foreach (var child in graph[node])
                DFS(child, result);
            cycleNodes.Remove(node);
            result.AddFirst(node);
        }
    }
}

