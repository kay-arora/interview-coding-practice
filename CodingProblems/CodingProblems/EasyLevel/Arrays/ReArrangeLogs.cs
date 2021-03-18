/*You are given an array of logs. Each log is a space-delimited string of words, where the first word is the identifier.

There are two types of logs:

Letter-logs: All words (except the identifier) consist of lowercase English letters.
Digit-logs: All words (except the identifier) consist of digits.
Reorder these logs so that:

The letter-logs come before all digit-logs.
The letter-logs are sorted lexicographically by their contents. If their contents are the same, then sort them lexicographically by their identifiers.
The digit-logs maintain their relative ordering.
Return the final order of the logs.*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class ReArrangeLogs
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            Dictionary<string, string> letterLogs = new Dictionary<string, string>();
            List<string> digitLogs = new List<string>();

            foreach(var log in logs)
            {
                //"dig1 8 1 5 1" , "let1 art can"

                var logData = log.Split(' ');

                if (char.IsDigit(logData[1][0]))
                    digitLogs.Add(log);
                else
                {
                    var logIdentifier = logData[0];
                    StringBuilder logContent = new StringBuilder();
                    for (int i = 1; i < logData.Length; i++)
                        logContent.Append(logData[i] + " ");

                    letterLogs.Add(logIdentifier, logContent.ToString().TrimEnd());
                }
            }

            var sorted = letterLogs.OrderBy(x => x.Value).ThenBy(x => x.Key);

            List<string> letterLogsSorted = new List<string>();

            foreach(var log in sorted)
            {
                string logData = log.Key + " " + log.Value;
                letterLogsSorted.Add(logData);
            }

            string[] result = new string[logs.Length];
            int index = 0;
            foreach(var elem in letterLogsSorted)
            {
                result[index] = elem;
                index++;
            }
            foreach (var elem in digitLogs)
            {
                result[index] = elem;
                index++;
            }

            return result;

        }
    }
}
