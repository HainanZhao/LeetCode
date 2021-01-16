using System;
using System.Collections.Generic;
using System.Text;

namespace OnstructBinarSearchTreeFromPreorderTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        private TreeNode constructTree(int[] preOrder, int low, int high)
        {
            if (low > high)
            {
                return null;
            }
            TreeNode node = new TreeNode(preOrder[low]);
            int midPoint = low + 1;
            while (midPoint <= high && preOrder[midPoint] < preOrder[low])
            {
                midPoint++;
            }
            node.left = constructTree(preOrder, low + 1, midPoint - 1);
            node.right = constructTree(preOrder, midPoint, high);
            return node;
        }
        public TreeNode BstFromPreorder(int[] preorder)
        {
            return constructTree(preorder, 0, preorder.Length - 1);
        }
    }
}
