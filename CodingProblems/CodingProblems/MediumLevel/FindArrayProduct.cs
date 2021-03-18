using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.MediumLevel
{
    public static class FindArrayProduct
    {
        public static int[] ProductExceptSelf(int[] nums)
        {

            int[] result = new int[nums.Length];
            int resultIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                int leftProduct = 1;
                int rightProduct = 1;

                if (i == 0)
                {
                    rightProduct = FindProduct(nums, i + 1, nums.Length - 1);
                }
                else if (i == nums.Length - 1)
                {
                    leftProduct = FindProduct(nums, 0, nums.Length - 2);
                }
                else
                {
                    leftProduct = FindProduct(nums, 0, i - 1);
                    rightProduct = FindProduct(nums, i + 1, nums.Length - 1);
                }

                result[resultIndex] = leftProduct * rightProduct;
                resultIndex++;
            }

            return result;
        }

        public static int FindProduct(int[] nums, int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= nums[i];
            }

            return product;
        }

        public static int[] OtherSolution(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int[] result = new int[nums.Length];
            int temp = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
        }
    }
}
