using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class MeanderingArray
    {
        public static void sortArray(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            int n = arr.Length;

            var newArr = new List<int>();

            for(int i=0, j= n-1; i <= j; i++, j--)
            {
                if(i == j)
                {

                    newArr.Add(arr[i]);
                }
                else
                {
                    newArr.Add(arr[i]);
                    newArr.Add(arr[j]);
                }
              
            }

            foreach(var a in newArr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
