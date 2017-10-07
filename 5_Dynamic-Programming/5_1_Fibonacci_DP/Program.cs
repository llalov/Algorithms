using System;

namespace _5_1_Fibonacci_DP
{
    class Program
    {
        static void Main()
        {
            //Fibonacci sequence
            //index: 0 1 2 3 4 5 6  7  8  9 10
            //Fib:   0 1 1 2 3 5 8 13 21 34 55

            Console.WriteLine(Fib(9));

            //Fibonacci Series using Dynamic Programming
            int Fib(int n)
            { 
                int[] numbers = new int[n + 1];
                numbers[0] = 0;
                numbers[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }
                return numbers[n];
            }
        }
    }
}
