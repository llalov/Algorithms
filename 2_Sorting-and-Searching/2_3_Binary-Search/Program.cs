using System;
using System.Diagnostics;

namespace _2_3_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 6, 7, 9, 12, 23, 24, 33, 45, 66, 71, 87, 92, 95 };
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int index = BinarySearch.IndexOf(array, 87);
            stopwatch.Stop();
            Console.WriteLine("Result: "+ index);
            Console.WriteLine("Execute in " + stopwatch.ElapsedMilliseconds.ToString() + " milliseconds");
        }
    }
}
