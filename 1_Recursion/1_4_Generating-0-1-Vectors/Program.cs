using System;
using System.Linq;

namespace _1_4_Generating_0_1_Vectors
{
    class Program
    {
        //Generates all possible 0-1 combinations in by passing n-lenght vector in the console
        //*note -  if you want to change the range of possible numbers edit the start and end numbers in the for loop below 
        public static void Gen01(int[] vector, int index)
        {
            if (index > vector.Length - 1)
            {
                Console.WriteLine("{0}", string.Join("", vector.Select(x => x.ToString())));      
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen01(vector, index + 1);
                }
            }
        }

        static void Main()
        {
            int vectorLength = Convert.ToInt32(Console.ReadLine());
            Gen01(new int[vectorLength], 0);
        }
    }
}
