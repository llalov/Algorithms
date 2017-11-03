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
                int key = Convert.ToInt32(Console.ReadLine().Split(':')[0]);

                List<int> children = Console.ReadLine().Split(':')[1].Split(' ').Select(x => Convert.ToInt32(x)).ToList();
                graph.Add(key, children);
            }

            for (int y = 0; y < pairsToFindCount; y++)
            {
                pairsToFind.Add(Console.ReadLine().Split('-').Select(x => Convert.ToInt32(x)).ToArray());
            }


        }
    }
}
