using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    /*
    The idea is create a HashMap where the edge nodes knows who is the left most and right most neighbor.
    e.g. [3, 1, 2, 100, 200, 4, 5, 6]
    In the begining
    3 - No neigbors found
    1 - No neighors found.
    Now we encouter a number, e.g. 2

    We check its left neighbor(1) about the left most neighbor he knows(1).
    Then check its right neighbor(3) about the right most neighbor he knows(3).
    Then share this information with the left most(1) and right most neighor(3), now node (3) knows the left most number is (1) and vice versa.
    Calculate the length of the range at the same time.
    */

    public class LongestConsecutiveSequence
    {
        class Range
        {
            public int LeftMost;
            public int RightMost;
        }

        public int LongestConsecutive(int[] nums)
        {

            var dict = new Dictionary<int, Range>();
            var maxLen = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                if (dict.ContainsKey(nums[i]))
                    continue;
                else
                {
                    var hasLeft = dict.ContainsKey(val - 1);
                    var hasRight = dict.ContainsKey(val + 1);
                    var leftMost = val;
                    var rightMost = val;
                    var len = 0;

                    if (hasLeft && hasRight)
                    {
                        leftMost = dict[val - 1].LeftMost;
                        rightMost = dict[val + 1].RightMost;
                        dict[leftMost].RightMost = rightMost;
                        dict[rightMost].LeftMost = leftMost;

                        len = rightMost - leftMost + 1;
                        dict.Add(val, null);
                    }
                    else if (hasLeft && !hasRight)
                    {
                        leftMost = dict[val - 1].LeftMost;
                        dict[leftMost].RightMost = val;
                        dict.Add(val, new Range() { LeftMost = leftMost, RightMost = val });

                        len = val - leftMost + 1;
                    }
                    else if (!hasLeft && hasRight)
                    {
                        rightMost = dict[val + 1].RightMost;
                        dict[rightMost].LeftMost = val;
                        dict.Add(val, new Range() { LeftMost = val, RightMost = rightMost });
                        len = rightMost - val + 1;
                    }
                    else
                    {
                        len = 1;
                        dict.Add(val, new Range() { LeftMost = val, RightMost = val });
                    }

                    if (maxLen < len)
                        maxLen = len;
                }
            }

            return maxLen;
        }
    }
}
