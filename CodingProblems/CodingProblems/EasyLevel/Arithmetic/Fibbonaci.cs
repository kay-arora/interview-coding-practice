using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arithmetic
{
    public static class Fibbonaci
    {
        public static int GetFib(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for(int i = 1; i <n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return sum;

        }

        public static int GetFibRecursively(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return GetFibRecursively(n -1) + GetFibRecursively(n - 2);
        }
    }
}
