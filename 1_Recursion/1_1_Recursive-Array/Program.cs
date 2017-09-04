using System;
using System.Linq;

namespace _1_1_Recursive_Array
{
    class Program
    {
        static int Sum(int[] array, int index)
        {
            if(index == array.Length - 1)
            {
                return array[index];
            }
            return array[index] + Sum(array, index + 1);
        }

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray();
            Console.WriteLine(Sum(input, 0));
        }
    }
}
