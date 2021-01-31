using System;
using System.Collections.Generic;
using System.Text;

namespace SlidingWindowMaximum
{
    public class Solution
    {

        public int[] MaxSlidingWindow(int[] nums, int k)
        {

            var res = new int[nums.Length - k + 1];
            var q = new LinkedList<int>();

            for (var i = 0; i < nums.Length; i++)
            {

                while (q.Count > 0 && nums[q.Last.Value] < nums[i])
                    q.RemoveLast();

                if (q.Count > 0 && i - q.First.Value >= k)
                    q.RemoveFirst();

                q.AddLast(i);

                if (i >= k - 1)
                    res[i - k + 1] = nums[q.First.Value];
            }

            return res;
        }
    }
}
