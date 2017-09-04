using System;

namespace _1_2_Recursive_Factorial
{
    class Program
    {
        public static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int factorial = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(factorial));
        }
    }
}
