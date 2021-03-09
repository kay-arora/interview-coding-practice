using System;
using CodingProblems.EasyLevel.Arithmetic;
using CodingProblems.EasyLevel.Arrays;
using CodingProblems.EasyLevel.LinkedLists;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode linkedTest = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 0,
                    next = new ListNode()
                    {
                        val = 1,
                        next = null
                    }
                }
            };


            Console.WriteLine(PallindromeLinkedList.IsPallindrome(linkedTest));

           
        }
    }
}
