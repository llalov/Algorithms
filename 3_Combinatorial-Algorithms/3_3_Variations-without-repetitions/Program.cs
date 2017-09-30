using System;

namespace _3_3_Variations_without_repetitions
{
    class Program
    {
        static void Main()
        {
            char[] elements = { 'A', 'B', 'C', 'D' };
            const int k = 2;// length of variation
            char[] variations = new char[k];// holding a single variation
            bool[] used = new bool[elements.Length];//used variations
            GenerateVariations(0, elements);

            //Generating variations of k elements.
            //Variations count: n!/(n-k)!
            void GenerateVariations<T>(int index, T[] array)
            {
                if (index >= k)
                {
                    Console.WriteLine(string.Join(" ", variations));
                }
                else
                {
                    for (int i = 0; i < elements.Length; i++)
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            variations[index] = elements[i];
                            GenerateVariations(index + 1, elements);
                            used[i] = false;
                        }
                    }
                }
            }
        }
    }
}
