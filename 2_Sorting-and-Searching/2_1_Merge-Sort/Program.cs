﻿using System;
using System.Diagnostics;

namespace _2_1_Merge_Sort
{
    class Program
    {
        static void Main()
        {
            int[] array = { 3, 10, 12, 6, 5, 44, 23, 88, 3, 6, 7, 94, 1, 4, 8, 2 , 9};
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MergeSort<int>.Sort(array);
            stopwatch.Stop();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Execute in " + stopwatch.ElapsedMilliseconds.ToString() + " milliseconds");
        }
    }
}
