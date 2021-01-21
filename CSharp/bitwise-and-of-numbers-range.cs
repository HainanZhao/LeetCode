using System;
using System.Collections.Generic;
using System.Text;

namespace BitWiseAndOfNumbersRange
{

    public class Solution
    {
        //Math.Log2 was not allowed.
        int MyLog2(int m)
        {
            var result = 0;
            for (var i = 1; i < 32; i++)
            {
                var min = 1 << i;
                if (min <= m)
                {
                    result = i;
                }
                else
                {
                    break;
                }
            }            
            return result;
        }

        public int RangeBitwiseAnd(int m, int n)
        {

            if (m == n)
                return m & n;

            if (MyLog2(m) != MyLog2(n))
                return 0;

            var diff = MyLog2(n - m);

            //If difference is 5, Log(2) is 2. Means all the last 2 digits would be changed if we iterate through m to n. 
            //Thus the bit AND for last 2 bits must be 0. 
            //So we can construct a mastk 11111111100 to filter out the result
            return m & n & ~((1 << diff + 1) - 1);
        }
    }
}
