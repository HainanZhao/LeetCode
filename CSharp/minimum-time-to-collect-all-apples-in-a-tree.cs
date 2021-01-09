using System;
using System.Collections.Generic;
using System.Text;


namespace MinimumTimeToCollectAllApplesInATree
{
    public class Solution
    {

        public class TreeNode
        {
            public bool HasApple;
            public bool IsPicked;
            public List<TreeNode> Nodes = new List<TreeNode>();
        }

        public int PickApple(TreeNode node)
        {
            node.IsPicked = true;
            if (node.Nodes.Count == 0)
            {
                return node.HasApple ? 2 : 0;
            }
            else
            {
                var sum = 0;
                foreach (var child in node.Nodes)
                {
                    if (!child.IsPicked)
                        sum += PickApple(child);
                }
                return sum > 0 ? sum + 2 : (node.HasApple ? 2 : 0);
            }
        }

        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            List<TreeNode> tree = new List<TreeNode>();
            for (int i = 0; i < n; i++)
            {
                var node = new TreeNode()
                {
                    HasApple = hasApple[i]
                };
                tree.Add(node);
            }

            for (int i = 0; i < edges.Length; i++)
            {
                var edge = edges[i];
                tree[edge[0]].Nodes.Add(tree[edge[1]]);
                tree[edge[1]].Nodes.Add(tree[edge[0]]);
            }

            var sum = PickApple(tree[0]);

            return sum > 0 ? sum - 2 : 0;
        }
    }
}
