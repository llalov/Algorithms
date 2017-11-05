using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_3_Distance_between_vertices
{
    class Program
    {
        static void Main(string[] args)
        {
            int verticesCount = Convert.ToInt32(Console.ReadLine());
            int pairsToFindCount = Convert.ToInt32(Console.ReadLine());
            List<int[]> pairsToFind = new List<int[]>();
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < verticesCount; i++)
            {
                string input = Console.ReadLine();

                int key = Convert.ToInt32(input.Split(':')[0]);

                List<int> children = new List<int>();
                try
                {
                    children = input.Split(':')[1].Split(' ').Select(x => Convert.ToInt32(x)).ToList();
                }
                catch (Exception)
                {
                    
                }
                
                graph.Add(key, children);
            }

            for (int y = 0; y < pairsToFindCount; y++)
            {
                pairsToFind.Add(Console.ReadLine().Split('-').Select(x => Convert.ToInt32(x)).ToArray());
            }
            List<int> result = new List<int>();
            var distanceFinder = new DistanceFinder(graph);
            distanceFinder.BFS(11, result);

            foreach(var item in result)
                Console.WriteLine(item);
        }
    }
}
