using System;
using System.Collections.Generic;
using System.Text;

namespace LongestPalindromicSubstring
{
    public class Solution
    {

        int GetIndex(int len, int i)
        {
            var sign = i % 2 == 1 ? 1 : -1;
            if (len % 2 == 0)
            {
                return len / 2 - 1 + sign * ((i + 1) / 2);
            }
            else
            {
                return len / 2 + sign * ((i + 1) / 2);
            }
        }
        public string LongestPalindrome(string s)
        {
            var res = "";
            var max = 0;

            for (var curr = 0; curr < s.Length; curr++)
            {
                var i = GetIndex(s.Length, curr);
                if (i < max / 2 - 1 || i > s.Length - max / 2)
                    break;

                //Odd length Loop
                var l = i;
                var r = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    var len = r - l + 1;
                    if (len > max)
                    {
                        max = len;
                        res = s.Substring(l, len);
                    }
                    l--;
                    r++;
                }

                //Even length loop
                l = i;
                r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    var len = r - l + 1;
                    if (len > max)
                    {
                        max = len;
                        res = s.Substring(l, len);
                    }
                    l--;
                    r++;
                }
            }
            return res;
        }
    }

}
