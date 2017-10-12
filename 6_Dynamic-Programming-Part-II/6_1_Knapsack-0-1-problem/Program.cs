using System;
using System.Collections.Generic;

namespace _6_1_Knapsack_0_1_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWeight = Convert.ToInt32(Console.ReadLine());
            List<int> weights = new List<int>();
            List<int> values = new List<int>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                values.Add(Convert.ToInt32(input.Split(' ')[1]));
                weights.Add(Convert.ToInt32(input.Split(' ')[0]));
            }

            int[] valuesArr = values.ToArray();
            int[] weightsArr = weights.ToArray();

            Console.WriteLine(Knapsack(maxWeight, weightsArr, valuesArr, values.Count));

            // finds the maximum value of combinations items in a knapsack with limited weight
            int Knapsack(int knapsackCapacity, int[] wt, int[] val, int countOfAllItems)
            {
                int[,] maxPrice = new int[countOfAllItems + 1, knapsackCapacity + 1];
                for (int row = 0; row <= countOfAllItems; row++)
                {
                    for (int col = 0; col <= knapsackCapacity; col++)
                    {
                        if (row == 0 || col == 0)
                        {
                            maxPrice[row,col] = 0;
                        }
                        else if(wt[row - 1] <= col) 
                        {
                            maxPrice[row, col] = Max(val[row - 1] + maxPrice[row - 1, col - wt[row - 1]], maxPrice[row - 1, col]);
                        }
                        else
                        {
                            maxPrice[row, col] = maxPrice[row - 1, col];
                        }
                    }
                }
                return maxPrice[countOfAllItems,knapsackCapacity];
            }

            int Max(int a, int b)
            {
                return (a > b) ? a : b;
            }
        }
    }
}
