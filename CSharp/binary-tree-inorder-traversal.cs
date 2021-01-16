using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeInOrderTravelsal
{    
    public class Solution
    {
        public void InOrder(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left, list);
            list.Add(root.val);
            InOrder(root.right, list);
        }
        
        public IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            InOrder(root, list);
            return list;
        }
    }
}
