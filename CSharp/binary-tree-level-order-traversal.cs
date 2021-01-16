using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class BinaryTreeLevelOrderTraversal
    {
        public class Solution
        {
            private void Order(TreeNode root, List<List<TreeNode>> list, int i)
            {
                if (root == null)
                {
                    return;
                }

                if (i >= list.Count)
                {
                    list.Add(new List<TreeNode>());
                }

                var currLevel = list[i];
                currLevel.Add(root);
                Order(root.left, list, i + 1);
                Order(root.right, list, i + 1);
            }
            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                List<List<TreeNode>> list = new List<List<TreeNode>>();
                Order(root, list, 0);

                var result = new List<IList<int>>();
                for (int i = 0; i < list.Count; i++)
                {
                    IList<int> row = new List<int>();
                    for (int j = 0; j < list[i].Count; j++)
                    {
                        row.Add(list[i][j].val);
                    }
                    result.Add(row);
                }

                return result;
            }
        }
    }
}
