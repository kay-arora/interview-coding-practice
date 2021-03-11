using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class MaxSubArray
    {
        public static int FindMaxSubArraySum(int[] nums)
        {
            //we will solve this using the greedy approach 
            //pick the locally optimal move at each step that will lead to a globally optimal solution
            //iterate the array and at each step keep on updating the current max sum, and the global max sum

            int n = nums.Length;
            int currSum = nums[0];
            int maxSum = nums[0];

            for(int i= 1; i <n; i++)
            {
                currSum = Math.Max(nums[i], currSum + nums[i]);
                maxSum = Math.Max(currSum, maxSum);
            }

            return maxSum;
        }
    }
}
