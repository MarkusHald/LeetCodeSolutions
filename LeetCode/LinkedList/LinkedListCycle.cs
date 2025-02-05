using LeetCode.Helpers;
using System.Collections.Generic;

namespace LeetCode.LinkedList
{    
     
    public class LinkedListCycle
    {
        HashSet<ListNode> seenNodes = new HashSet<ListNode>();

        public bool HasCycleRecursion(ListNode head)
        {
            if (head is null) return false;
            else if (seenNodes.Contains(head)) return true;
            else seenNodes.Add(head);
            return HasCycleRecursion(head.next);
        }

        public bool HasCycleWhile(ListNode head)
        {
            if (head is null) return false;

            seenNodes.Add(head);
            var ln = head.next;

            while (ln is not null)
            {
                if (seenNodes.Contains(ln)) return true;
                else seenNodes.Add(ln);
                ln = ln.next;
            };
            return false;
        }
    }
}
