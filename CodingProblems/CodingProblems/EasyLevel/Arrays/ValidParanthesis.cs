using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class ValidParanthesis
    {
        public static bool IsParanthesisValid(string s)
        {
            //first let's do a validation on the length
            //if the length is an odd number, then we know that the string is unbalanced

            if (s.Length % 2 != 0)
                return false;

            //create a dictionary
            // Key = }, value = {
            // key = ), value = (
            // key = ], value = [

            //go over the string, whenever we find an opening bracket by checking dictionary.contains, we push bracket into stack whenever it is an opening brace
            //whenenver we find a closing brace, we pop the element from stack, compare the popped value to the value for the closing brace key in the dictionary
            //if it matches, we move on, if not we return false
            //At the end, we check if the stack is empty. If it is still not empty, then we return false, else true


            var bracketMap = new Dictionary<char, char>()
            {
                {')', '(' },
                {'}', '{' },
                {']', '[' }
            };

            var stackRef = new Stack<char>();

            foreach(char c in s)
            {
                if (!bracketMap.ContainsKey(c))
                {
                    stackRef.Push(c);
                    continue;
                }

                char top = stackRef.Count > 0 ? stackRef.Pop() : '#';
                if (top != bracketMap[c])
                    return false;
            }

            return (stackRef.Count == 0);
        }
    }
}
