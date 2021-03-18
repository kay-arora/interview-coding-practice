using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class ValidPallindrome
    {
        public static bool IsPallindrome(string s, int low, int high)
        {
            var charArr = s.ToCharArray();

            while(low <= high)
            {
                if (charArr[low] != charArr[high])
                    return false;
                else
                {
                    low++;
                    high--;
                }
            }

            return true;
        }

        public static bool ValidateForPallindrome(string s)
        {

            int low = 0;
            int high = s.Length - 1;
            var charArr = s.ToCharArray();

            while(low < high)
            {
                if(charArr[low] == charArr[high])
                {
                    low++;
                    high--;
                }
                else
                {
                    if (IsPallindrome(s, (low + 1), high))
                        return true;

                    if (IsPallindrome(s, low, (high - 1)))
                        return true;

                    return false;
                }
            }

            return true;
        }

        public static bool ValidateForOnlyAlphaNumericChars(string s)
        {
            int low = 0;
            int high = s.Length - 1;
            var charArr = s.ToCharArray();

           

            while(low < high)
            {
                while (low < high && !char.IsLetterOrDigit(charArr[low]))
                    low++;

                while (low < high && !char.IsLetterOrDigit(charArr[high]))
                    high--;

                if (char.ToLower(charArr[low]) != char.ToLower(charArr[high]))
                    return false;

                low++;
                high--;
            }

            return true;
        }
    }
}
