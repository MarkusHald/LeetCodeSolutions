namespace LeetCode.LinkedListTasks
{
    public static class MiddelOfLinkedList
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (true)
            {
                if (fast.next is null)
                {
                    return slow;
                }
                else if (fast.next.next is null)
                {
                    return slow.next;
                }

                slow = slow.next;
                fast = fast.next.next;
            }
        }
    }
}
