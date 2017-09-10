using System;
using System.Linq;

namespace _1_5_Generating_Combinations
{
    class Program
    {
        public static void GenComb(int[] set, int[] vector, int index, int border)
        {
            if (index > vector.Length - 1)
            {
                Console.WriteLine("{0}", string.Join(",", vector.Select(x => x.ToString())));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenComb(set, vector, index + 1, i + 1);
                }
            }
        }

        static void Main()
        {
            int[] set = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x)).ToArray();
            int vectorLength = Convert.ToInt32(Console.ReadLine());

            GenComb(set, new int[vectorLength], 0, 0);
        }

        //EXAMPLE
        //-----------------
        //|Input  | Output|
        //-----------------
        //|1 2 3 4|1,2    |
        //|2      |1,3    |
        //|       |1,4    |
        //|       |2,3    |
        //|       |2,4    |
        //|       |3,4    |
        //-----------------

    }
}

