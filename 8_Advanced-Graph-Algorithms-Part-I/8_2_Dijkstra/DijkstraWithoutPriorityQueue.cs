using System;
using System.Collections.Generic;
using System.Text;


public class DijkstraWithoutPriorityQueue
{
    public static List<int> DijkstraAlgorithm(int[,] graph, int sourceNode, int destinationNode)
    {
        int n = graph.GetLength(0);
        int[] distance = new int[n];

        for (int i = 0; i < n; i++)
            distance[i] = int.MaxValue;
        
        distance[sourceNode] = 0;
        var used = new bool[n];
        int?[] previous = new int?[n];

        while(true)
        {
            //Find the nearest unused node from the graph
            int minDistance = int.MaxValue;
            int minNode = 0;
            for (int node = 0; node < n; node++)
            {
                if (!used[node] && distance[node] < minDistance)
                {
                    minDistance = distance[node];
                    minNode = node;
                }
            }
            if (minDistance == int.MaxValue)
                break;
            used[minNode] = true;

            for (int i = 0; i < n; i++)
            {
                if (graph[minNode,i] > 0)
                {
                    int newDist = distance[minNode] + (graph[minNode,i]);
                    if (newDist < distance[i])
                    {
                        distance[i] = newDist;
                        previous[i] = minNode;
                        //update previous if nesscesary
                    }
                }
            }
        }

        if (distance[destinationNode] == int.MaxValue)
            return null;

        //Reconstruct the shortest path from sourceNode to destinationNode
        var path = new List<int>();
        int? currentNode = destinationNode;
        while (currentNode != null)
        {
            path.Add(currentNode.Value);
            currentNode = previous[currentNode.Value];
        }
        path.Reverse();
        return path;
    }
}

