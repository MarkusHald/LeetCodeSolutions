namespace LeetCode.LinkedList
{
    public class MergeSortedLinkedLists
    {
        public ListNode Execute(ListNode list1, ListNode list2)
        {
            if (list1 is null)
            {
                return list2;
            }

            if (list2 is null)
            {
                return list1;
            }

            if (list1.val <= list2.val)
            {
                list1.next = Execute(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = Execute(list1, list2.next);
                return list2;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
