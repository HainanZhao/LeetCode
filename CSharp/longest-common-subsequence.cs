using System;
using System.Collections.Generic;
using System.Text;

namespace LongestCommonSubsequnce
{
/*
  a  b  c  c
b 0  1  1  1
d 0  1  1  1
c 0  1  2  2  

Note that the value won't increase if you move it from left to right or top to down even there's a match.
*/

    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var len1 = text1.Length;
            var len2 = text2.Length;
            var dict = new int[len1 + 1, len2 + 1];

            for (var i = 0; i < len1; i++)
            {
                for (var j = 0; j < len2; j++)
                {
                    var lefttop = dict[i, j];
                    var left = dict[i, j + 1];
                    var top = dict[i + 1, j];
                    if (text1[i] == text2[j])
                    {
                        dict[i + 1, j + 1] = lefttop + 1;
                    }
                    else
                    {
                        dict[i + 1, j + 1] = Math.Max(left, top);
                    }
                }
            }
            return dict[len1, len2];
        }
    }
}
