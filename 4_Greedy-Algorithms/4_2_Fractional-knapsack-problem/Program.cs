using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_2_Fractional_knapsack_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightCapacity = Convert.ToInt32(Console.ReadLine());
            int items = Convert.ToInt32(Console.ReadLine());
            SortedDictionary<float, Dictionary<int, int>> menu = new SortedDictionary<float, Dictionary<int, int>  > ();

            for (int i = 0; i < items; i++)
            {
                string[] input = Console.ReadLine().Split(' ').Select(x => x.ToString()).ToArray();

                float value = Convert.ToInt32(input[0]) / Convert.ToInt32(input[2]);
                menu.Add(value, new Dictionary<int, int>());
                menu[value].Add(Convert.ToInt32(input[0]), Convert.ToInt32(input[2]));
                // value -> (price, weight)
            }
            var currentCapacty = 0;
            int itemIndex = 0;
            float price = 0f;
            while (currentCapacty != weightCapacity && itemIndex < menu.Count)
            {
                var item = menu.ElementAt(itemIndex).Value;
                Console.WriteLine(item.Values.ElementAt(0));
                
                itemIndex++;
            }

        }
    }
}
