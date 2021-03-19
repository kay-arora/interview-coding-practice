using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.LinkedLists
{
    public static class RemoveLinkedListElements
    {
        public static ListNode RemoveElementsFromList(ListNode head, int val)
        {
            
            var dummy = new ListNode(0);
            var cur = dummy;
            while (head != null)
            {
                if (head.val != val)
                {
                    cur.next = head;
                    cur = cur.next;
                }
                head = head.next;
            }
            cur.next = null;
            return dummy.next;
        }
    }
}
