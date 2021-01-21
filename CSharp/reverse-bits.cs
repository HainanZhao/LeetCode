using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseBits
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (var i = 0; i < 32; i++)
            {
                result <<= 1;
                //Combine the bits in result and the last bit of n. Can also use the + operator.
                result |= (n & 1);                
                n >>= 1;
            }
            return result;
        }
    }
}
