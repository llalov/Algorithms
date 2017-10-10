using System;
using System.Linq;

namespace _5_4_Rod_Cutting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int rodLength = Convert.ToInt32(Console.ReadLine());

            int[] bestPrice = new int[price.Length];
            int[] bestCombo = new int[price.Length];
            Array.Copy(price, bestPrice, price.Length);

            Console.WriteLine(CutRod(rodLength));

            int CutRod(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    int currentBest = bestPrice[i];
                    for (int j = 1; j <= i; j++)
                    {
                        currentBest =
                             Math.Max(bestPrice[i], price[j] + bestPrice[i - j]);
                        if (currentBest > bestPrice[i])
                        {
                            bestPrice[i] = currentBest;
                            bestCombo[i] = j;
                        }
                    }
                }
                return bestPrice[n];
            }

        }
    }
}
