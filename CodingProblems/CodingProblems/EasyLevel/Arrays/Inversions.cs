using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class Inversions
    {
        public static int getInversions(int[] nums)
        {
            int length = nums.Length;
            var resultList = new List<List<int>>();

            if (length < 3)
                return 0;

            int i = 0;

            while(i < length - 3)
            {
                int j = i + 1;
                while(j < length - 2)
                {
                    int k = i + 2;
                    while (k < length - 1)
                    {
                        resultList.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        k++;
                    }
                    j++;
                }
                i++;
            }
            //get sub-sequences of three while maintaining order

            return 0;

        }

        public static void PrintSubsequences(int[] arr, int n)
        {

            // Number of subsequences is (2**n -1)
            int opsize = (int)Math.Pow(2, n);

            // Run from counter 000..1 to 111..1
            for (int counter = 1; counter < opsize; counter++)
            {
                for (int j = 0; j < n; j++)
                {

                    // Check if jth bit in the counter is set 
                    // If set then print jth element from arr[] 
                    if ((counter & (1 << j)) != 0)
                        Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void GetSubsequences(int[] arr, int n)
        {

            // Number of subsequences is (2**n -1)
            int opsize = (int)Math.Pow(2, n);
            var result = new List<List<int>>();
            var size3Lists = new List<List<int>>();
            var inversions = new List<List<int>>();

            // Run from counter 000..1 to 111..1
            for (int counter = 1; counter < opsize; counter++)
            {
                var subList = new List<int>();

                for (int j = 0; j < n; j++)
                {
                    // Check if jth bit in the counter is set 
                    // If set then print jth element from arr[] 
                    if ((counter & (1 << j)) != 0)
                        subList.Add(arr[j]);
                }

                result.Add(subList);
            }

            //find all lists with size three
            foreach(var elem in result)
            {
                if (elem.Count == 3)
                    size3Lists.Add(elem);
            }

            //find all lists in descending order
            foreach(var elem in size3Lists)
            {
                int first = elem[0];
                int second = elem[1];
                int third = elem[2];

                if (first > second && second > third)
                    inversions.Add(elem);
                    
            }


        }
    }
}
