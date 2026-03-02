namespace BuyAndSellStocks
{
    internal class Program
    {
        static int maxProfit(int[] input)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < minPrice)
                {
                    minPrice = input[i];
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, input[i] - minPrice);
                }
            }
            return maxProfit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total no of days:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int[] input2 = new int[input1];
            Console.WriteLine("Enter the stock prices:");
            for(int i=0; i<input1; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Maximum Profit: " + maxProfit(input2));
        }
    }
}
