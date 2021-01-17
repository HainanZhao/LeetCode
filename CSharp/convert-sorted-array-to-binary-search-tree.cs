using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertSortedArrayToBST
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            return ToTree(nums, 0, nums.Length - 1);
        }

        TreeNode ToTree(int[] nums, int start, int end)
        {
            if (start > end)
                return null;

            var node = new TreeNode();
            var mid = (start + end) / 2;
            node.val = nums[mid];
            node.left = ToTree(nums, start, mid - 1);
            node.right = ToTree(nums, mid + 1, end);

            return node;
        }
    }
}
