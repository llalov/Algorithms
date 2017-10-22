﻿using System;
using System.Collections.Generic;
using System.Linq;

    public class GraphConnectedComponents
    {
        static List<int>[] graph = new List<int>[]
     {
        new List<int>() { 3, 6 },       //0
        new List<int>() { 3, 4, 5, 6 }, //1
        new List<int>() { 8 },          //2
        new List<int>() { 0, 1, 5 },    //3
        new List<int>() { 1, 6 },       //4
        new List<int>() { 1, 3 },       //5
        new List<int>() { 0, 1, 4 },    //6
        new List<int>() { },            //7
        new List<int>() { 2 }           //8
     };

        public static void Main()
        {
            //re-writing graph from console input
            graph = ReadGraph();
            FindGraphConnectedComponents();
        }

        private static List<int>[] ReadGraph()
        {
            int n = int.Parse(Console.ReadLine());
            var graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
            }
            return graph;
        }

        private static void FindGraphConnectedComponents()
        {
            visited = new bool[graph.Length];
            for (int startNode = 0; startNode < graph.Count(); startNode++)
            {
                if (!visited[startNode])
                {
                    Console.Write("Connected component:");
                    DFS(startNode);
                    Console.WriteLine();
                }
            }
        }

        static bool[] visited;

        private static void DFS(int vertex)
        {
            if (!visited[vertex])
            {
                visited[vertex] = true;
                foreach (var child in graph[vertex])
                {
                    DFS(child);
                }
                Console.Write(" " + vertex);
            }
        }
    }
