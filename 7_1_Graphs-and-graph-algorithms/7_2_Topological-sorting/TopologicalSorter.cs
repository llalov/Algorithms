using System.Collections.Generic;
using System.Linq;

public class TopologicalSorter
{
    private Dictionary<string, List<string>> graph;
    private Dictionary<string, int> predecessorCount;

    public TopologicalSorter(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    public ICollection<string> TopSort()
    {
        List<string> sorted = new List<string>();
        GetPredecessorCount(graph);
        while (true)
        {
            string nodeToRemove = predecessorCount.Keys.Where(x => predecessorCount[x] == 0).FirstOrDefault();
            if (nodeToRemove == null)
                break;

            foreach(var child in graph[nodeToRemove])
                predecessorCount[child]--;
            graph.Remove(nodeToRemove);
            sorted.Add(nodeToRemove);
        }
        return sorted;
    }

    private void GetPredecessorCount(Dictionary<string, List<string>> graph)
    {
        predecessorCount = new Dictionary<string, int>();
        foreach(var node in graph)
        {
            if (!predecessorCount.ContainsKey(node.Key))
                predecessorCount[node.Key] = 0;

            foreach(var child in node.Value)
            {
                if (!predecessorCount.ContainsKey(child))
                    predecessorCount[child] = 0;
                predecessorCount[child]++;
            }
        }
    }
}

