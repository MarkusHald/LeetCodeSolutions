namespace LeetCode.StringTasks
{
    public static class IsPalindrome
    {
        public static bool Execute(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left <= right)
            {
                if (!Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else if (Char.ToLower(s[left]) == Char.ToLower(s[right]))
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
