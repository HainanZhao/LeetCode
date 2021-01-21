using System;
using System.Collections.Generic;
using System.Text;

namespace BitWiseAndOfNumbersRange
{

    public class Solution
    {
        //Compare the MSB
        public int RangeBitwiseAnd(int m, int n)
        {

            var result = 0;
            for (var i = 31; i >= 0; i--)
            {
                var mask = 1 << i;
                var newM = m & mask;
                if (newM == (n & mask))
                    result |= newM;
                else
                    return result;
            }

            return result;
        }
    }
}
