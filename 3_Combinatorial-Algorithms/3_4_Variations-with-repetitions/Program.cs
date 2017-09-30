using System;

namespace _3_4_Variations_with_repetitions
{
    class Program
    {
        static void Main()
        {

            const int k = 3;
            int n = 5;
            int[] elements = new int[k];

            //Variations with repetitions. Iterative algorithm.
            //Variations count: n power k. (In this case 5*5*5 = 125)
            while (true)
            {
                Console.WriteLine(String.Join(" ", elements));
                int index = k - 1;
                while (index >= 0 && elements[index] == n - 1)
                {
                    index--;
                }
                if (index < 0)
                {
                    break;
                }
                elements[index]++;
                for (int i = index + 1; i < k; i++)
                {
                    elements[i] = 0;
                }
            }
        }
    }
}
