using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {

                if (dict.ContainsKey(target - nums[i]))
                {
                    var index = dict[target - nums[i]];
                    if (index != i)
                        return new int[] { i, index };
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }

            }

            return new int[] { 0, 0 };
        }
    }
}
