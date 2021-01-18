using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateBinarySearchTree
{
    public class Solution
    {

        bool InOrderTraversal(TreeNode root, Stack<int> stack)
        {
            if (root == null)
                return true;

            if (!InOrderTraversal(root.left, stack))
                return false;

            if (stack.Count > 0 && root.val <= stack.Peek())
                return false;
            stack.Push(root.val);

            if (!InOrderTraversal(root.right, stack))
                return false;

            return true;
        }


        public bool IsValidBST(TreeNode root)
        {

            var stack = new Stack<int>();

            return InOrderTraversal(root, stack);
        }
    }
}
