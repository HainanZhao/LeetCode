﻿using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymmetricTree
{
    public class Solution
    {
        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;
            else if (left == null || right == null)
                return false;
            else if (left.val != right.val)
                return false;
            else if (left.left == null && left.right == null && right.left == null && right.right == null)
                return true;
            else
                return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }

        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetric(root.left, root.right);
        }
    }
}
