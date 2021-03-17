using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class MajorityElement
    {
        public static int FindMajorityElement(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length / 2];
        }


        //given an array of size n; find all elements that appear more than n/3 times
        public static List<int> FindAllMajorityElems(int[] arr)
        {
            Dictionary<int, int> elemCount = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach(var num in arr)
            {
                if (elemCount.ContainsKey(num))
                    elemCount[num]++;
                else
                {
                    elemCount.Add(num, 1);
                }
            }

            var majElem = arr.Length / 3;

            foreach(var elem in elemCount)
            {
                if (elem.Value > majElem)
                    result.Add(elem.Key);
            }

            return result;
        }
    }
}
