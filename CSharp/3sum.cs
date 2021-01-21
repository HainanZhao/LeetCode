using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();
            if (nums.Length < 3)
                return list;

            Array.Sort(nums);

            var len = nums.Length;
            for (int i = 0; i < len - 2; i++)
            {

                var target = -nums[i];

                //Skip the duplicate 1st int
                if (i > 0 && nums[i - 1] == nums[i])
                    continue;

                int slow = i + 1, fast = len - 1;
                while (slow < fast)
                {
                    if (nums[slow] + nums[fast] > target)
                    {
                        fast--;
                    }
                    else if (nums[slow] + nums[fast] < target)
                    {
                        slow++;
                    }
                    else
                    {
                        var li = new List<int>() { nums[i], nums[slow], nums[fast] };
                        list.Add(li);
                        slow++;

                        //Skip the duplicate 2nd int
                        while (slow < fast && nums[slow] == nums[slow - 1])
                            slow++;
                    }
                }
            }

            return list;
        }
    }
}
