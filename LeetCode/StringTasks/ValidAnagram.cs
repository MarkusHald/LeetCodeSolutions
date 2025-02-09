namespace LeetCode.StringTasks
{
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var dict = new Dictionary<char, int>();
            var l = s.Length;

            for (int i = 0; i < l; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                {
                    dict[s[i]]++;
                }

                if (!dict.ContainsKey(t[i]))
                {
                    dict.Add(t[i], -1);
                }
                else
                {
                    dict[t[i]]--;
                }
            }

            return !dict.Values.Any(x => x > 0);
        }
    }
}
