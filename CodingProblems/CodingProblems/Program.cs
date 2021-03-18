using System;
using CodingProblems.CrackingTheCodingInterview.ArraysAndStrings;
using CodingProblems.EasyLevel.Arithmetic;
using CodingProblems.EasyLevel.Arrays;
using CodingProblems.EasyLevel.LinkedLists;
using CodingProblems.EasyLevel.Strings;
using CodingProblems.EasyLevel.Trees;
using CodingProblems.General_Concepts.Trees;
using CodingProblems.MediumLevel;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = {
                new int[] { 1, 91 },
                new int[] { 1, 92 },
                new int[] { 2, 93 },
                new int[] { 2, 97 },
                new int[] { 1, 60 },
                new int[] { 2, 77 },
                new int[] { 1, 65 },
                new int[] { 1, 87 },
                new int[] { 1, 100 },
                new int[] { 2, 100 },
                new int[] { 2, 76 }
            };

            //string s = "Bob hit a ball, the hit BALL flew far after it was hit.";

            SingleNumber.FindSingleNumber(new int[] {4, 1, 2, 1, 2 });
        }
    }
}
