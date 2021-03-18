using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class LongestCommonPrefix
    {
        public static string FindLongestCommonPrefix(string[] words)
        {
            List<char[]> wordArrays = new List<char[]>();

            foreach(var word in words)
            {
                wordArrays.Add(word.ToCharArray());
            }

            return "";
        }
    }
}
