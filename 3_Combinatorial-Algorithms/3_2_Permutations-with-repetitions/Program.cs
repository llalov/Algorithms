using System;
using System.Collections.Generic;

namespace _3_2_Permutations_with_repetitions
{
    class Program
    {
        static void Main()
        {
            char[] elements = { 'A', 'B', 'C', 'B','A'};
            Array.Sort(elements);
            GenPermutations(elements, 0, elements.Length - 1);
          
            //Generating permutation with repetitions (avoid duplicates because by definition A B'B'' == A B''B')
            //Permutation count here is: 5! / 2!*2!*1! = 30
            //Explanation: 5 - number of elements; / (A = 2, B = 2, C = 1)
            void GenPermutations<T>(T[] array, int start, int end)
            {
                Console.WriteLine(string.Join(" ", elements));
                for (int left = end - 1; left >= start; left--)
                {
                    for (int right = left + 1; right <= end; right++)
                    {
                        if (elements[left] != elements[right])
                        {
                            Swap(elements, left, right);
                            GenPermutations(elements, left + 1, end);
                        }
                    }
                    var firstElement = elements[left];
                    for (int i = left; i <= end - 1; i++)
                    {
                        elements[i] = elements[i + 1];
                    }
                    elements[end] = firstElement;
                }
            }

            void Swap<T>(T[] array, int index1, int index2)
            {
                var element1 = array[index1];
                array[index1] = array[index2];
                array[index2] = element1;
            }
        }
    }
}
