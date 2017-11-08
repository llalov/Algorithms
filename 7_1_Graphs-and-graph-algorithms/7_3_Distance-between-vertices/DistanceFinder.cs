using System.Collections.Generic;
using System.Linq;

public class DistanceFinder
{
    private Dictionary<int, List<int>> graph;
    private Queue<int> path;
    private HashSet<int> visited = new HashSet<int>();

    public DistanceFinder(Dictionary<int, List<int>> graph)
    {
        this.graph = graph;
    }

    public Dictionary<int, LinkedList<int>> FindShortestPath(int start, int end)
    {
        Dictionary<int, LinkedList<int>> distanceAndPath = new Dictionary<int, LinkedList<int>>();
        List<int> result = new List<int>();
        BFS(start, result);
        graph = BFSOrderedGraph(graph, result);
        int distance = 0;
        LinkedList<int> shortestPath = new LinkedList<int>();
        if (result.Contains(end))
        {
            int startIndex = result.IndexOf(start);
            int endIndex = result.IndexOf(end);
            int searchedVal = end;
            shortestPath.AddFirst(end);
            while (searchedVal != start)
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    List<int> currentChildren = graph.Values.ElementAt(i);
                    if (currentChildren.Contains(searchedVal))
                    {
                        shortestPath.AddFirst(graph.Keys.ElementAt(i));
                        distance++;
                        searchedVal = graph.Keys.ElementAt(i);
                        break;
                    }
                }
            }
        }
        else
        {
            distance = -1;
            shortestPath.AddFirst(-1);
        }
        distanceAndPath.Add(distance, shortestPath);
        return distanceAndPath;
    }

    private Dictionary<int, List<int>> BFSOrderedGraph(Dictionary<int, List<int>> graph, List<int> keysOrder)
    {
        Dictionary<int, List<int>> BFSgraph = new Dictionary<int, List<int>>();
        foreach (var key in keysOrder)
            BFSgraph.Add(key, graph[key]);
        return BFSgraph;
    }
    
    private void BFS(int node, List<int> result)
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

