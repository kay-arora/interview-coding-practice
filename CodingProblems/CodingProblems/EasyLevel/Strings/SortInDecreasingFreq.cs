using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingProblems.EasyLevel.Strings
{
    public static class SortInDecreasingFreq
    {
        public static string SortCharsInDescFrequency(string s)
        {
            Dictionary<char, int> charFreqMap = new Dictionary<char, int>();

            foreach(char ch in s)
            {
                if (charFreqMap.ContainsKey(ch))
                {
                    charFreqMap[ch]++;
                }
                else
                {
                    charFreqMap.Add(ch, 1);
                }
            }

            var sortInDescFreq = charFreqMap.OrderByDescending(x => x.Value);

            StringBuilder result = new StringBuilder();

            foreach(var elem in sortInDescFreq)
            {
                for(int i=0; i < elem.Value; i++)
                {
                    result.Append(elem.Key);
                }
            }

            return result.ToString();
        }
    }
}
