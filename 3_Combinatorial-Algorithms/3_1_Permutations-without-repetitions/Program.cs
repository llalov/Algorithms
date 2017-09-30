using System;

namespace _3_1_Permutations_without_repetitions
{
    class Program
    {
        public static void Main()
        {
            char[] elements = { 'A', 'B', 'C', 'D' };
            GeneratePermWithoutRep(0, elements);

            //Generating permutations without repetitions (it's preffered the elements to be unique)
            //Permutations count is factorial of elements count (in this case 4! => 24)
            void GeneratePermWithoutRep<T>(int index, T[] array)
            {
                if (index >= elements.Length)
                {
                    Console.WriteLine(string.Join(" ", elements)); 
                } 
                else
                {
                    GeneratePermWithoutRep(index + 1, elements);
                    for (int i = index + 1; i < elements.Length; i++)
                    {
                        Swap(elements, index, i);
                        GeneratePermWithoutRep(index + 1, elements);
                        Swap(elements, index, i);
                    }
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
