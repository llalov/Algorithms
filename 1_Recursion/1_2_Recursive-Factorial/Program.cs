using System;

namespace _1_2_Recursive_Factorial
{
    class Program
    {
        public static int Factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int fact = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(fact));
        }
    }
}
