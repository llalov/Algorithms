using System;

namespace _2_1_Merge_Sort
{
    class Program
    {
        static void Main()
        {
            int[] array = { 3, 10, 12, 6, 5, 44, 23, 88, 3, 6, 7, 94, 1, 4, 8, 2 , 9};
            MergeSort<int>.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
