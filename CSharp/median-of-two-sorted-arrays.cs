using System;
using System.Collections.Generic;
using System.Text;

namespace MediumOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            int head1 = 0, head2 = 0;
            for (int i = 0; i < nums1.Length + nums2.Length; i++)
            {
                if (head1 >= nums1.Length)
                {
                    list.Add(nums2[head2]);
                    head2++;
                } else if (head2 >= nums2.Length)
                {
                    list.Add(nums1[head1]);
                    head1++;
                }
                else if (nums1[head1] <= nums2[head2])
                {
                    list.Add(nums1[head1]);
                    head1++;
                }
                else
                {
                    list.Add(nums2[head2]);
                    head2++;
                }
            }

            var lengh = list.Count;
            if (lengh % 2 == 1)
            {
                return list[(lengh - 1)/2];
            }
            else
            {
                return (list[lengh / 2] + list[lengh / 2 - 1]) * 0.5;
            }
        }
    }
}
