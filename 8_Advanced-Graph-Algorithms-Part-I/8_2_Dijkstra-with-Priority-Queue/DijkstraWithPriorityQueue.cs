using System.Collections.Generic;

public static class DijkstraWithPriorityQueue
{
    public static List<int> DijkstraAlgorithm(Dictionary<Node, Dictionary<Node, int>> graph, Node sourceNode, Node destinationNode)
    {
        int?[] previous = new int?[graph.Count];
        bool[] visited = new bool[graph.Count];
        PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>();

        //distances will be reset to infinity for each new search
        foreach (var pair in graph)
            pair.Key.DistanceFromStart = double.PositiveInfinity;
        sourceNode.DistanceFromStart = 0;
        priorityQueue.Enqueue(sourceNode);
        visited[sourceNode.Id] = true;

        while (priorityQueue.Count > 0)
        {
            var currentNode = priorityQueue.ExtractMin();
            if (currentNode.Id == destinationNode.Id)
                break;

            foreach (var edge in graph[currentNode])
            {
                if (!visited[edge.Key.Id])
                {
                    priorityQueue.Enqueue(edge.Key);
                    visited[edge.Key.Id] = true;
                }

                var distance = currentNode.DistanceFromStart + edge.Value;
                if (distance < edge.Key.DistanceFromStart)
                {
                    edge.Key.DistanceFromStart = distance;
                    previous[edge.Key.Id] = currentNode.Id;
                    //decreases the value of and element and reorders the priority queue so the 
                    //changed element is repositioned in its correct place and the heap property is kept
                    priorityQueue.DecreaseKey(edge.Key);
                }
            }
        }
        if (destinationNode.DistanceFromStart == double.PositiveInfinity)
            return null;
        List<int> path = new List<int>();
        int? current = destinationNode.Id;
        while (current != null)
        {
            path.Add(current.Value);
            current = previous[current.Value];
        }
        path.Reverse();
        return path;
    }
}

