using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class MostCommonWord
    {
        public static string GetMostCommonWord(string para, string[] banned)
        {
            //string s = "Bob hit a ball, the hit BALL flew far after it was hit.";

            var words = para.Split(new char[] { ' ', '!', '?', '\'', ',', ';', '.', '"' });
            string result = string.Empty;

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach(var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;
                if (wordCount.ContainsKey(word.ToLower()))
                {
                    wordCount[word.ToLower()]++;
                }
                else
                {
                    wordCount.Add(word.ToLower(), 1);
                }
            }

            var mostCommonWord = wordCount.OrderByDescending(x => x.Value);

            foreach(var elem in mostCommonWord)
            {
                if (!banned.Contains(elem.Key))
                    return elem.Key;
            }

            return result;
        }
    }
}
