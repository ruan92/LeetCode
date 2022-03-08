// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int MaxProfit(int[] prices)
{
    var low = prices[0];
    var high = 0;
    var profit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] < low)
        {
            low = prices[i];
            high = 0;
        }
        else if (prices[i] > high)
        {
            high = prices[i];
            if (high - low > profit)
                profit = high - low;
        }
    }

    return profit;
}