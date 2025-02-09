namespace LeetCode.StringTasks
{
    public static class LongestPalindrome
    {
        public static int FindLongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }

            var hs = new HashSet<char>();
            var palindromLength = 0;

            foreach (var letter in s)
            {
                if (hs.Contains(letter))
                {
                    hs.Remove(letter);
                    palindromLength = palindromLength + 2;
                }
                else
                {
                    hs.Add(letter);
                }
            }

            if (hs.Count > 0)
            {
                return ++palindromLength;
            }

            return palindromLength;
        }
    }
}
