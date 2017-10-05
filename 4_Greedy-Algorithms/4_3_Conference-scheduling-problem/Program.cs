using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_3_Conference_scheduling_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int lecturesCount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int[]> lectures = new Dictionary<string, int[]>();

            for (int i = 0; i < lecturesCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ').Select(x => x).ToArray();
                int lectureStart = Convert.ToInt32(input[1]);
                int lectureEnd = Convert.ToInt32(input[3]);
                lectures.Add(input[0], new int[]{lectureStart, lectureEnd});
            }

            //ascending sorted lectures by their finish time 
            List<KeyValuePair<string, int[]>> sortedLectures = lectures.ToList();
            sortedLectures.Sort((pair1, pair2) => pair1.Value[1].CompareTo(pair2.Value[1]));

            for (int i = 0; i < sortedLectures.Count; i++)
            {
                Console.WriteLine(sortedLectures[i].Key);
            }
        }
    }
}
