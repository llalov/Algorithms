using System;
using System.Collections.Generic;
using System.Linq;

public class KruskalAlgorithm
{
    public static List<Edge> Kruskal(int numberOfVertices, List<Edge> edges)
    {
        var parent = new int[numberOfVertices];
        int root = edges[0].StartNode;

        for (int i = 0; i < numberOfVertices; i++)
        {
            parent[i] = i;
        }
        edges.Sort((x, y) => x.CompareTo(y));

        //Minimum spanning tree
        List<Edge> spanningTree = new List<Edge>();

        foreach (var edge in edges)
        {
            int rootStartNode = FindRoot(edge.StartNode, parent);
            int rootEndNode = FindRoot(edge.EndNode, parent);
            if (rootStartNode != rootEndNode) //No Cycle
            {
                //Add edge to MST
                spanningTree.Add(edge);
                //Mark one root as parent of the other (merge trees)
                parent[rootStartNode] = parent[rootEndNode];
            }
        }
        return spanningTree;
    }

    public static int FindRoot(int node, int[] parent)
    {
        int root = node;
        while (parent[root] != root)
        {
            root = parent[root];
        }
        return root;
    }
}

