namespace LeetCode.Array
{
    public static class TwoSum
    {
        public static int[] Execute(int[] nums, int target)
        {
            var l = nums.Count();
            if (l.Equals(2))
            {
                return [0, 1];
            }

            var d = new Dictionary<int, int>();

            for (int i = 0; i < l; i++)
            {
                var a = target - nums[i];

                if (d.ContainsKey(a))
                {
                    return [i, d[a]];
                }

                d.TryAdd(nums[i], i);
            }
            return [];
        }
    }
}
