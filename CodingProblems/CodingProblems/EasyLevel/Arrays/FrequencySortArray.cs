using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class FrequencySortArray
    {
        public static int[] FrequencySort(int[] nums)
        {
            var freqMap = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if (freqMap.ContainsKey(num))
                {
                    freqMap[num]++;
                }
                else
                {
                    freqMap.Add(num, 1);
                }
            }

            var sortedNums = freqMap.OrderBy(x => x.Value)
                                        .ThenByDescending(x => x.Key)
                                        .Select(x => x.Key)
                                        .ToList();


            int[] result = new int[nums.Length];
            int index = 0;

            foreach(var num in sortedNums)
            {
                for(int i = 0; i < freqMap[num]; i++)
                {
                    result[index] = num;
                    index++;
                }
            }

            return result;

        }
    }
}
