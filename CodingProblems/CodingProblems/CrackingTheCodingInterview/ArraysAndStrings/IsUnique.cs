/* Implement an algorithm to determine if a string has all unique characters. What if we do not use an additional data structure?*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingProblems.CrackingTheCodingInterview.ArraysAndStrings
{
    public static class IsUnique
    {
        public static bool IsUniqueCharsUsingHashMap(string s)
        {
            Dictionary<char, int> freqMap = new Dictionary<char, int>();

            foreach(var ch in s)
            {
                if (!freqMap.ContainsKey(ch))
                    freqMap.Add(ch, 1);
                else
                {
                    freqMap[ch]++;

                }
            }

            if (freqMap.Any(x => x.Value > 1))
                return false;
            else
                return true;
        }

        public static bool IsUniqueCharsInPlace(string s)
        {
            var chrArray = s.ToCharArray();
            Array.Sort(chrArray);
            char prevCh = chrArray[0];

            for(int i=1; i < chrArray.Length; i++)
            {
                if (chrArray[i] == prevCh)
                    return false;

                prevCh = chrArray[i];
                
            }

            return true;
        }
    }
}
