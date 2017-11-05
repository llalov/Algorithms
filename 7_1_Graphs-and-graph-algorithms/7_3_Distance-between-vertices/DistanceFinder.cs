using System;
using System.Collections.Generic;
using System.Text;


public class DistanceFinder
{
    private Dictionary<int, List<int>> graph;
    private Queue<int> path;
    private HashSet<int> visited = new HashSet<int>();

    public DistanceFinder(Dictionary<int, List<int>> graph)
    {
        this.graph = graph;
    }

    public Dictionary<int, List<int>> FindShortestPath(int start, int end)
    {
        Dictionary<int, List<int>> distanceAndPath = new Dictionary<int, List<int>>();
        List<int> result = new List<int>();

        BFS(start, result);
        
        return distanceAndPath;
    }

    public void BFS(int node, List<int> result)
    {
        path = new Queue<int>();
        path.Enqueue(node);
        visited.Add(node);
        while(path.Count != 0)
        {
            var currentNode = path.Dequeue();
            result.Add(currentNode);
            foreach(var child in graph[currentNode])
            {
                if (!visited.Contains(child))
                {
                    path.Enqueue(child);
                    visited.Add(child);
                }
            }
        }
    }
}

