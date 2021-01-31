using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlidingWindowMedian
{
    public class Solution
    {
        void BalanceHeap(SortedSet<int> left, SortedSet<int> right, int[] nums)
        {
            if (Math.Abs(left.Count - right.Count) <= 1)
                return;
            else if (left.Count > right.Count)
            {
                var max = left.Max;
                left.Remove(max);
                right.Add(max);
            }
            else
            {
                var min = right.Min;
                right.Remove(min);
                left.Add(min);
            }
        }

        double GetMedian(SortedSet<int> left, SortedSet<int> right, int[] nums, bool isOdd)
        {
            if (isOdd)
                return left.Count > right.Count ? nums[left.Max] : nums[right.Min];
            else
                return nums[left.Max] * 0.5 + nums[right.Min] * 0.5;
        }

        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            var comparer = Comparer<int>.Create((x, y) => nums[x] != nums[y] ? (nums[x] > nums[y] ? 1 : -1) : (x - y));
            var leftHeap = new SortedSet<int>(comparer);
            var rightHeap = new SortedSet<int>(comparer);
            var isOdd = k % 2 == 1;
            var res = new double[nums.Length - k + 1];

            for (var i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                if (leftHeap.Count > 0 && nums[leftHeap.Max] >= val)
                {
                    leftHeap.Add(i);
                }
                else if (rightHeap.Count > 0 && nums[rightHeap.Min] < val)
                {
                    rightHeap.Add(i);
                }
                else
                {
                    leftHeap.Add(i);
                }

                BalanceHeap(leftHeap, rightHeap, nums);
                
                if (i >= k - 1)
                {
                    res[i - k + 1] = GetMedian(leftHeap, rightHeap, nums, isOdd);

                    if (!leftHeap.Remove(i - k + 1))
                        rightHeap.Remove(i - k + 1);
                }
            }
            return res;
        }
    }
}
