namespace LeetCode.LinkedListTasks
{
    public static class ReverseLinkedList
    {        
        public static ListNode ReverseList(ListNode head)
        {
            if (head is null)
            {
                return null;
            }

            var stack = new Stack<ListNode>();

            while (head != null)
            {
                stack.Push(head);
                head = head.next;
            }

            head = stack.Pop();
            var temp = head;
            while (stack.Count > 0)
            {
                var top = stack.Pop();
                temp.next = top;
                temp = top;                
            }
            temp.next = null;
            return head;
        }
    }
}
