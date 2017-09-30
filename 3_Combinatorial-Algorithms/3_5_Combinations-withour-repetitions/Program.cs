using System;

namespace _3_5_Combinations_withour_repetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 3;
            int n = 5;
            int[] elements = new int[k];
            GenerateCombinations(0, 0);
            
            //Generate combinations for k elements in n length collection.
            //Combinations count: n! / k!(n-k)!
            void GenerateCombinations(int index, int start)
            {
                if (index >= k)
                {
                    Console.WriteLine(String.Join(" ", elements));
                }
                else
                {
                    for (int i = start; i < n; i++)
                    {
                        elements[index] = i;
                        GenerateCombinations(index + 1, i + 1);
                    }
                }
            }
        }
    }
}
