namespace LeetCode.Array
{
    public static class MajorityElement
    {
        public static int ExecuteEff(int[] nums)
        {
            var ordered = nums.OrderBy(x => x);
            return ordered.ToArray()[nums.Length / 2];
        }

        public static int Execute(int[] nums)
        {
            var l = nums.Length;
            var halfL = l / 2;
            var d = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                }
                else { d[i] = 1; }
            }
            return d.MaxBy(x => x.Value).Key;
        }
    }

}
