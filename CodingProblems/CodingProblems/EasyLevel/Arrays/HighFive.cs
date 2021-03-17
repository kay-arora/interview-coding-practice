using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class HighFive
    {
        public static int[][] GetHighFive(int[][] items)
        {

            SortedDictionary<int, List<int>> scoresMap = new SortedDictionary<int, List<int>>();

            foreach (var elem in items)
            {
                var id = elem[0];
                var score = elem[1];

                if (scoresMap.ContainsKey(id))
                {
                    scoresMap[id].Add(score);
                }
                else
                {
                    scoresMap.Add(id, new List<int> { score });
                }
            }

            var total = scoresMap.Count;

            int[][] result = new int[total][];
            int resultIndex = 0;

            
            foreach (var elem in scoresMap)
            {
                var id = elem.Key;
                var scores = elem.Value;

                scores.Sort();
                scores.Reverse();

                int top5Sum = 0;
                for (int i = 0; i < 5; i++)
                    top5Sum += scores[i];

                result[resultIndex] = new int[] { id, top5Sum / 5 };
                resultIndex++;
            }


            return result;

        }
    }
}
