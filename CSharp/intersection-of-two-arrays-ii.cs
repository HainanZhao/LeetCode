using System;
using System.Collections.Generic;
using System.Text;

namespace IntersectionOfTwoArraysII
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dict.ContainsKey(nums1[i]))
                {
                    dict.Add(nums1[i], 1);
                }
                else
                {
                    dict[nums1[i]]++;
                }
            }

            var dict2 = new Dictionary<int, int>();
            for (int j = 0; j < nums2.Length; j++)
            {
                if (dict.ContainsKey(nums2[j]))
                {
                    if (!dict2.ContainsKey(nums2[j]))
                        dict2.Add(nums2[j], 1);
                    else
                        dict2[nums2[j]]++;
                }
            }

            var list = new List<int>();
            foreach (var key in dict2.Keys)
            {
                for (int i = 0; i < Math.Min(dict2[key], dict[key]); i++)
                    list.Add(key);
            }

            return list.ToArray();
        }
    }
}
