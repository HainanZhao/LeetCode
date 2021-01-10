using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIndex
{
    public class Solution
    {
        public int HIndex(int[] citations)
        {
            var list = citations.ToList().OrderByDescending(x=>x).ToList();
            var h = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] >= i + 1)
                {
                    h = i + 1;
                }                
            }

            return h;
        }
    }
}
