using System;
using System.Collections.Generic;
using System.Text;

namespace DivideTwoIntegers
{
    public class Solution
    {

        public int GetSum(List<int> sums, List<int> muls, int divident)
        {
            var sum = 0;
            var mul = 0;
            for (int i = sums.Count - 1; i >= 0 ; i--)
            {
                if (sum + sums[i] > 0 || sum + sums[i] < divident)
                {
                    continue;
                }
                if (sum == divident)
                {
                    mul += muls[i];
                    break;
                }
                else if (sum > divident)
                {
                    sum += sums[i];
                    mul += muls[i];
                }                     
            }

            return mul;
        }

        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
                return 0;
            else if (divisor == 0)
                return 0;

            bool positiveResult = (dividend > 0 && divisor > 0)||(dividend < 0 && divisor < 0);
            dividend = dividend > 0 ? 0 - dividend : dividend;
            divisor = divisor > 0 ? 0 - divisor : divisor;

            List<int> sums = new List<int>();
            List<int> muls = new List<int>();

            sums.Add(divisor);
            muls.Add(-1);
            int index = 0;
            while (sums[index] > dividend && sums[index] < 0)
            {
                var newSum = sums[index] + sums[index];
                if (newSum > 0)
                    break;
                sums.Add(newSum);
                muls.Add(muls[index] + muls[index]);
                index++;                
            }

            var sum = GetSum(sums, muls, dividend);
            return positiveResult ? (sum == -2147483648 ? 2147483647 : 0 - sum): sum;
        }
    }
}
