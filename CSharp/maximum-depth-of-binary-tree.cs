﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumDepthOfBinaryTree
{
   
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }
            else if (root.left == null && root.right == null)
            {
                return 1;
            }
            else if (root.left == null && root.right != null)
            {
                return MaxDepth(root.right) + 1;
            }
            else if (root.left != null && root.right == null)
            {
                return MaxDepth(root.left) + 1;
            }
            else
            {
                return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
            }
        }
    }
}