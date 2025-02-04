namespace LeetCode.Stack
{
    public static class ValidParentheses
    {
        public static bool Execute(string s)
        {
            var stack = new Stack<char>();
            char[] openingParans = ['(', '{', '['];
            char[] closingParans = [')', '}', ']'];
            var d = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

            foreach (var paran in s)
            {
                if (openingParans.Contains(paran))
                {
                    stack.Push(paran);
                }
                else if (closingParans.Contains(paran))
                {
                    if (stack.Count.Equals(0))
                    {
                        return false;
                    }

                    var topParan = stack.Pop();
                    if (!d[paran].Equals(topParan))
                    {
                        return false;
                    }
                }
            }
            return stack.Count().Equals(0);
        }
    }
}
