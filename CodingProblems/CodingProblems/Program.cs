using System;
using CodingProblems.EasyLevel.Arrays;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = TwoSumProblem.GetTwoSumProblemResult(new int[] { 5, 6, 2, 3, 8, 9 }, 11);

            foreach (var i in result)
                Console.WriteLine(i);
        }
    }
}
