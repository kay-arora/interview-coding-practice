using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class SingleNumber
    {
        public static int FindSingleNumber(int[] nums)
        {

            Array.Sort(nums);
            int tracker = nums[0];
            int counter = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == tracker)
                    counter++;
                else
                    tracker = nums[i];
            }

            return tracker;


        }
    }
}
