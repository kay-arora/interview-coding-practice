/*
 * Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.

Return the decimal value of the number in the linked list.

 Input: head = [1,0,1]
Output: 5
Explanation: (101) in base 2 = (5) in base 10*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.LinkedLists
{
    public static class ConvertBinaryToDecimal
    {
        public static int CaclulateIntValueFromBinary(ListNode head)
        {
            //first reverse the linked list
            //then convert to decimal by multiplying powers of 2

            ListNode current = head;
            ListNode prev = null;

            while(current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            //now we have the linked list reversed with the new head as prev
            int power = 0;
            int decimalResult = 0;
            ListNode listIndex = prev;
            while(listIndex != null)
            {
                decimalResult += listIndex.val * Convert.ToInt32(Math.Pow(2, power));
                power++;
                listIndex = listIndex.next;
            }

            return decimalResult;

        }

        public static int calculateByAnotherMethod(ListNode head)
        {
            int num = head.val;

            while(head.next != null)
            {
                num = num * 2 + head.next.val;
                head = head.next;
            }

            return num;
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
