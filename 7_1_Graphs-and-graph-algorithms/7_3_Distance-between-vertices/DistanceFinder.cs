using System;
using System.Collections.Generic;
using System.Text;


public class DistanceFinder
{
    private Dictionary<string, List<string>> graph;
    private Queue<int> path;
    private HashSet<int> visited = new HashSet<int>();

    public DistanceFinder(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    private void BFS(int node, LinkedList<int> result)
    {
        path = new Queue<int>();
       
    }
}

