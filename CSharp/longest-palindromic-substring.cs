using System;
using System.Collections.Generic;
using System.Text;

namespace LongestPalindromicSubstring
{
    public class Solution
    {

        public string LongestPalindrome(string s)
        {
            var res = "";
            var max = 0;

            for (var i = 0; i < s.Length - max / 2; i++)
            {
                //Odd Loop
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
