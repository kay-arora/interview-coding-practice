using System;
using CodingProblems.EasyLevel.Arithmetic;
using CodingProblems.EasyLevel.Arrays;
using CodingProblems.EasyLevel.LinkedLists;
using CodingProblems.EasyLevel.Trees;
using CodingProblems.General_Concepts.Trees;

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

            var result = HighFive.GetHighFive(input);
        }
    }
}
