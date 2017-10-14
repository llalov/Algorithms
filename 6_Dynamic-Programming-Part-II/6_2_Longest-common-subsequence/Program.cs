using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_2_Subset_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //finds the first available subset(exactly 2 digist) from a set of numbers, which sum is eaqual to the target
            //EXAMPLE:
            //12 4 2 3 23 1 2 4 5 7 5
            //target: 10
            //output: 3,7
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int targetSum = Convert.ToInt32(Console.ReadLine());
            List<int> solutionSubset = FindSubset(input, targetSum, CalcPossibleSums(input, targetSum));
            Console.WriteLine(string.Join(",", solutionSubset));

            Dictionary<int, int> CalcPossibleSums(int[] numbers, int searchedSum)
            {
                Dictionary<int, int> possibleSums = new Dictionary<int, int>();
                possibleSums.Add(0, 0);
                for (int i = 0; i < numbers.Length; i++)
                {
                    var newSums = new Dictionary<int, int>();
                    foreach (var sum in possibleSums.Keys)
                    {
                        int currentSum = numbers[i] + possibleSums[sum];
                        if (!possibleSums.ContainsKey(currentSum) && !newSums.ContainsKey(currentSum))
                            newSums.Add(currentSum, numbers[i]);
                    }
                    foreach (var sum in newSums)
                        possibleSums.Add(sum.Key, sum.Value);
                }
                return possibleSums;
            }

            List<int> FindSubset(int[] numbers, int searchedSum, Dictionary<int, int> possibleSums)
            {
                List<int> subset = new List<int>();
                while(true)
                {
                    if (!possibleSums.ContainsKey(searchedSum) || possibleSums[searchedSum] <= 0)
                        break;
                    subset.Add(possibleSums[searchedSum]);
                    searchedSum -= possibleSums[searchedSum];
                }
                return subset;
            }
        }
    }
}
