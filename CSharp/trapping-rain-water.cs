using System;
using System.Collections.Generic;
using System.Text;

namespace TrappingRainWater
{
    public class Solution
    {
        private int FindTrapHeight(int index, int leftMax, int[] height)
        {            
            var rightMax = 0;
            if (index < height.Length - 1)
            {
                for (int i = index + 1; i < height.Length; i++)
                {
                    if (height[i] > rightMax)
                    {
                        rightMax = height[i];
                    }
                }
            }

            return Math.Min(leftMax, rightMax);            
        }
        public int Trap(int[] height)
        {
            var sum = 0;
            var leftMax = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (i > 0 && leftMax < height[i-1])
                {
                    leftMax = height[i-1];
                }
                var h = FindTrapHeight(i, leftMax, height);
                sum += h > height[i] ? h - height[i] : 0;
            }

            return sum;
        }
    }
}
