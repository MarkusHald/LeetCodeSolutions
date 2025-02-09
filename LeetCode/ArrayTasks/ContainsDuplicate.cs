namespace LeetCode.ArrayTasks
{
    public class ContainsDuplicate
    {
        public bool Execute(int[] nums)
        {
            var d = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if ( d.ContainsKey(item))
                {
                    return true;
                }
                d.Add(item, 0);
            }
            return false;
        }
    }
}
