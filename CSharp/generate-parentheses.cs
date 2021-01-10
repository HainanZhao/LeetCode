using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateParentheses
{
    public class Solution
    {

        private HashSet<string> MergeChildList(HashSet<string>left, HashSet<string> right)
        {
            var list = new HashSet<string>();
            foreach (var l in left)
            {
                for (int i = 0; i < l.Length; i++)
                {
                    foreach (var r in right)
                    {
                        var newItem = l.Substring(0, i + 1) + r + l.Substring(i + 1, l.Length - i - 1);
      
                        list.Add(newItem);                 
                    }                   
                }
            }

            return list;
        }
        public IList<string> GenerateParenthesis(int n)
        {
            var masterList = new List<HashSet<string>>() { new HashSet<string>(){ "()" } };
            if (n == 1)
            {
                return masterList[0].ToList();
            }

            HashSet<string> curr = null;
            for (int i = 2; i <= n; i++)
            {
                curr = new HashSet<string>();
                for (int j = 0; j < i/2; j++)
                {
                    var prevLeft = masterList[j];
                    var prevRight = masterList[i- 1 - j - 1];
                    var list = MergeChildList(prevLeft, prevRight);
                    list.UnionWith(MergeChildList(prevRight, prevLeft));
                    foreach (var item in list)
                    {     
                        curr.Add(item);
                    }
                }

                masterList.Add(curr);
            }

            return curr.ToList();
        }
    }
}
