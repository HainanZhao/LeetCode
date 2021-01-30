using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlidingWindowMedian
{
    public class Solution
    {
        void Insert(List<int> list, int val)
        {

            var index = list.BinarySearch(val);
            if (index >= 0)
                list.Insert(index, val);
            else
            {
                index = ~index;
                if (index >= list.Count)
                    list.Add(val);
                else
                    list.Insert(index, val);
            }
        }

        void Remove(List<int> list, int val)
        {
            var index = list.BinarySearch(val);
            list.RemoveAt(index);
        }

        public double[] MedianSlidingWindow(int[] nums, int k)
        {

            var currList = nums[0..k].ToList();
            currList.Sort();
            var isOdd = k % 2 == 1;
            var res = new double[nums.Length - k + 1];
            for (var i = 0; i < nums.Length - k + 1; i++)
            {
                if (isOdd)
                    res[i] = currList[k / 2];
                else
                    res[i] = currList[k / 2] * 0.5 + currList[k / 2 - 1] * 0.5;


                Remove(currList, nums[i]);
                if (i < nums.Length - k)
                {
                    Insert(currList, nums[i + k]);
                }

            }

            return res;
        }
    }
}
