/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class TwoSumProblem
    {
        public static int[] GetTwoSumProblemResult(int[] nums, int target)
        {
            //we are going to use a dictionary to solve this problem
            //we can either create a dictionary as step1, and story key value as nums[i], i
            //but this will require us two create and look-up the dictionary two times
            //lets do a single pass of the array, creating the dictionary on the fly
            //we will exit the program as soon as we find the result

            var numIndexLookUp = new Dictionary<int, int>();

            for(int i=0; i<nums.Length; i++)
            {
                var complement = target - nums[i];
                if (numIndexLookUp.ContainsKey(complement))
                    return new int[] { i, numIndexLookUp[complement] };

                numIndexLookUp.Add(nums[i], i);
            }

            throw new Exception("no result found");
        }


    }
}
