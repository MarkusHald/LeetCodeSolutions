namespace LeetCode.ArrayTasks
{
    public static class InsertInterval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var l = intervals.Length;
            var res = new List<int[]>();
            var idx = 0;

            while (idx < l && intervals[idx][1] < newInterval[0])
            {
                res.Add(intervals[idx]);
                idx++;
            }
            while (idx < l && intervals[idx][0] <= newInterval[1])
            {
                newInterval[0] = int.Min(intervals[idx][0], newInterval[0]);
                newInterval[1] = int.Max(intervals[idx][1], newInterval[1]);
                idx++;
            }
            res.Add(newInterval);
            while (idx < l)
            {
                res.Add(intervals[idx]);
                idx++;
            }
            return res.ToArray();
        }
    }
}
