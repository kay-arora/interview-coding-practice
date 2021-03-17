using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class MoveZeroes
    {
        //we need to move all the zeroes in an array to the end of the array
        //approach would be to keep track of the last index of the non-zero element
        //we will iterate the array and whenenever we get a non-zero element, we insert it at the last index of non-zero element+1
        //a second pass would be done to fill up zeros from last index of non-zero element to the end of the array

        public static int[] MoveZeroesToEnd(int[] nums)
        {
            int lastIndexOfNonZeroElem = 0;

            for(int i=0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[lastIndexOfNonZeroElem] = nums[i];
                    lastIndexOfNonZeroElem++;
                }
            }

            for(int i= lastIndexOfNonZeroElem; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
