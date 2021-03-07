/*Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.

Note:

The length of both num1 and num2 is < 5100.
Both num1 and num2 contains only digits 0-9.
Both num1 and num2 does not contain any leading zero.
You must not use any built-in BigInteger library or convert the inputs to integer directly.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public static class AddStrings
    {
        public static string AddTwoStrings(string num1, string num2)
        {
            //we will use basic arithmetic to solve the problem
            //let's start with the last character of num1 and num2 
            // we will add both characters
            // the addition could be >10, in that case we need to record the value of the carry over

            StringBuilder result = new StringBuilder();

            char[] number1 = num1.ToCharArray();
            char[] number2 = num2.ToCharArray();

            int index1 = number1.Length - 1;
            int index2 = number2.Length - 1;
            int carry = 0;

            while(index1 >= 0 || index2 >= 0)
            {
                //each character is internally represented by a number
                //the numbers 0 to 9 are represented by consecutive numbers
                //thus if foo = '2' , when we do '2' - '0' we can get the actual int 2
                //else if we just do '2' we will get the integer representation of '2'
                int x1 = index1 >= 0 ? number1[index1] - '0' : 0;
                int x2 = index2 >= 0 ? number2[index2] - '0': 0; 
                int val = (x1 + x2 + carry) % 10;
                carry = (x1 + x2 + carry) / 10;
                result.Append(val);
                index1--;
                index2--;
            }

            if(carry != 0)
            {
                result.Append(carry);
            }

            var reversedResult = result.ToString().ToCharArray();
            Array.Reverse(reversedResult);
            var finalResult = new string(reversedResult);

            return  finalResult;
        }
    }
}
