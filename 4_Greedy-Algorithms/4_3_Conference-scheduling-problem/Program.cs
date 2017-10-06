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

            //here will be stored the selected lectures which does not overlap with each other.
            List<KeyValuePair<string, int[]>> suitableLectures = new List<KeyValuePair<string, int[]>>();

            var last = sortedLectures[0];
            suitableLectures.Add(sortedLectures[0]);
            for (int i = 0; i < sortedLectures.Count; i++)
            {
                if (sortedLectures[i].Value[0] >= last.Value[1])
                {
                    suitableLectures.Add(sortedLectures[i]);
                    last = sortedLectures[i];
                }   
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lectures: "+suitableLectures.Count);
            for (int i = 0; i < suitableLectures.Count; i++)
            {
                Console.WriteLine(suitableLectures[i].Value[0] +" - "+suitableLectures[i].Value[1]+ " -> "+ suitableLectures[i].Key);
            }
        }
    }
}
