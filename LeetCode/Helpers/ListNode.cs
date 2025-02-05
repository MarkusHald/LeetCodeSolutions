namespace LeetCode.Helpers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public void GenerateChildren(int amountOfChildren)
        {
            var temp = new ListNode(val + 1);
            next = temp;
            
            for (int j = val + 2; j < amountOfChildren + 1; j++)
            {
                temp.next = new ListNode(j);
                temp = temp.next;
            }
        }
    }
}
