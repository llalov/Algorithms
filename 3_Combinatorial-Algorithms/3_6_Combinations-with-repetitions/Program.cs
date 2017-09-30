using System;

namespace _3_6_Combinations_with_repetitions
{
    class Program
    {
        static void Main()
        {
            const int k = 3;
            int n = 5;
            int[] elements = new int[k];
            GenerateCombinations(0, 0);

            //Generate combinations with repetitions for k elements in n length collection.
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
                        GenerateCombinations(index + 1, i);
                    }
                }
            }
        }
    }
}
