using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.EasyLevel.Strings
{
    public static class FirstNonRepeatingChar
    {
        public static int GetIndexOfFirstNonRepeatingChar(string s)
        {
            Dictionary<char, int> refList = new Dictionary<char, int>();
            
            foreach(var ch in s)
            {
                if (refList.ContainsKey(ch))
                {
                    refList[ch]++;
                }
                else
                {
                    refList.Add(ch, 1);
                }
            }

            int minIndex = s.Length;

            if(refList.Any(x => x.Value == 1))
            {
                foreach (var elem in refList)
                {
                    if (elem.Value == 1)
                    {
                        var index = s.IndexOf(elem.Key);
                        if (index < minIndex)
                            minIndex = index;
                    }

                }
            }

            if (minIndex == s.Length)
                return -1;
            else
                return minIndex;
        }
    }
}
