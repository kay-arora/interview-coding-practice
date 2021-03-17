using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public class WordDistance
    {
        Dictionary<string, List<int>> locations;

        public WordDistance(string[] words)
        {
            locations = new Dictionary<string, List<int>>();
            for(int i=0; i< words.Length; i++)
            {
                if (locations.ContainsKey(words[i])){
                    locations[words[i]].Add(i);
                }
                else
                {
                    locations.Add(words[i], new List<int> { i });
                }
            }
        }

        public int Shortest(string word1, string word2)
        {
            List<int> loc1, loc2;

            loc1 = locations.GetValueOrDefault(word1);
            loc2 = locations.GetValueOrDefault(word2);

            int index1 = 0;
            int index2 = 0;
            int minDist = int.MaxValue;

            if (loc1 != null && loc2 != null)
            {

                while(index1 < loc1.Count && index2 < loc2.Count)
                {
                    minDist = Math.Min(minDist, Math.Abs(loc1[index1] - loc2[index2]));
                    if (loc1[index1] < loc2[index2])
                        index1++;
                    else
                        index2++;
                }
            }

            return minDist;
        }
    }
}
