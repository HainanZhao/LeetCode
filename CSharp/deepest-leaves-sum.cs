using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepestLeavesSum
{     
    public class Solution
    {

        List<TreeNode> currList = null;
        List<TreeNode> nextList = null;

        public void PopulateNextList(List<TreeNode> currList)
        {
            nextList = new List<TreeNode>();
            foreach (var node in currList)
            {
                if (node.left != null)
                    nextList.Add(node.left);

                if (node.right != null)
                    nextList.Add(node.right);
            }
        }

        public int DeepestLeavesSum(TreeNode root)
        {
            PopulateNextList(new List<TreeNode>() { root });
            while (nextList.Count > 0)
            {
                currList = nextList;
                PopulateNextList(currList);
            }

            var sum = 0;
            foreach (var node in currList)
            {
                sum += node.val;
            }

            return sum;
        }
    }
}
