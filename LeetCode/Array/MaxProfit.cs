namespace LeetCode.Array
{
    public static class MaxProfit
    {
        public static int Execute(int[] prices)
        {
            var l = prices.Length;
            var profit = 0;
            var fast = 1;
            var slow = 0;

            while (fast < l)
            {

                if (prices[slow] >= prices[fast])
                {
                    slow = fast;
                }
                else
                {
                    var dayProfit = prices[fast] - prices[slow];
                    if (dayProfit > profit)
                    {
                        profit = dayProfit;
                    }
                }
                fast++;
            }
            return profit;
        }
    }
}
