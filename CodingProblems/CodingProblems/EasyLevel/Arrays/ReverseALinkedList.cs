/*
 * Given the head of a linked list, reverse the linked list
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class ReverseALinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            //we want to track two variables, the current and the previous
            //aim is to make the current point to the previous
            //but for that, we first need to store the current.next value in a temp variable
            //so, after that make current point to the previous
            //make current as the previous
            //make the value stored in the temp variable as current

            ListNode current = head;
            ListNode prev = null;

            while(current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            //because this would now contain the last element
            //while current would be null
            return prev;
        }
    }


    //definition of the linked list
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
