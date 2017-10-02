using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {

        //Consider the US currency coins: { 0.01, 0.02, 0.05, 0.10}
        //Problem "Sum of Coins":
        //Gather a sum of money, using less as possible number of coins

        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }
       
    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {

        var sortedCoins = coins.OrderByDescending(c => c).ToList();
        var chosenCoins = new Dictionary<int, int>();
        var currentSum = 0;
        var coinIndex = 0;
        while (currentSum != targetSum && coinIndex < sortedCoins.Count)
        {
            var currentCoinValue = sortedCoins[coinIndex];
            var remainingSum = targetSum - currentSum;
            int numberOfCoinsToTake = remainingSum / currentCoinValue;
            if (numberOfCoinsToTake > 0)
            {
                chosenCoins.Add(currentCoinValue, numberOfCoinsToTake);
                currentSum += numberOfCoinsToTake * currentCoinValue;
            }
            coinIndex++;
        }
        if (currentSum != targetSum)
        {
            throw new InvalidOperationException("Greedy algorithm cannot produce desired sum with specified coins.");
        }
        return chosenCoins;
    }
}