using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumLengthOfRepeatedSubArray
{
    public class Solution
    {
        public int FindLength(int[] A, int[] B)
        {
            var lenA = A.Length;
            var lenB = B.Length;
            var max = 0;
            var map = new int[lenA + 1, lenB + 1];
            for (var i = 0; i < lenA; i++)
            {
                for (var j = 0; j < lenB; j++)
                {
                    if (A[i] == B[j])
                    {
                        map[i + 1, j + 1] = map[i, j] + 1;
                        max = Math.Max(max, map[i + 1, j + 1]);
                    }
                    else
                        map[i + 1, j + 1] = 0;
                }
            }

            return max;
        }
    }
}
