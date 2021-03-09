/*Given a signed 32-bit integer x, return x with its digits reversed.
 * If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
 
 Input: x = 123
Output: 321*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arithmetic
{
    public static class ReverseSignedInt
    {
        public static int Reverse(int x)
        {
            if (x < Int32.MinValue || x > Int32.MaxValue)
                return 0;

            int rev = 0;
            while(x != 0)
            {
                int pop = x % 10;
                x = x / 10;

                //check overflow conditions
                if ((rev > Int32.MaxValue / 10) || (rev > Int32.MaxValue / 10 && pop > 7)) //because if rev > maxValue/10, in the next step when we do rev * 10, this will cause overflow
                    return 0;
                if ((rev < Int32.MinValue / 10 || (rev < Int32.MinValue / 10 && pop < -8)))
                    return 0;

                //else
                rev = rev * 10 + pop;
            }

            return rev;
        }

    }
}
