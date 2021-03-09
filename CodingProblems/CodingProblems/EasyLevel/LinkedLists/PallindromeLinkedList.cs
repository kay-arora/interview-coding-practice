/*Given the head of a singly linked list, return true if it is a palindrome.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.LinkedLists
{
    public static class PallindromeLinkedList
    {
        public static bool IsPallindrome(ListNode head)
        {
            //find out the first and second half of the list using slow-fast pointer method
            //reverse second half
            //compare elements in first and second half and see if values are equal

            if (head == null)
                return true;

            var endOfFirstHalf = EndOfFirstHalf(head);
            var reversedSecondHalf = ReverseSecondHalf(endOfFirstHalf.next); //the endOfFirstHalf.Next will take care of ignoring the middle event in odd numbered lists

            bool result = true;
            var p1 = head;
            var p2 = reversedSecondHalf;
            while(result && p2 != null)
            {
                if (p1.val != p2.val)
                    result = false;

                p1 = p1.next;
                p2 = p2.next;
            }

            return result;
        }

        public static ListNode EndOfFirstHalf(ListNode head)
        {
            var fast = head;
            var slow = head;
            while(fast.next != null && fast.next.next != null)
            {
                //when fast reaches the end, slow would point to the middle element
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }

        public static ListNode ReverseSecondHalf(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while(current != null)
            {
                var temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            return prev;
        }
    }
}
