using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public class Solution
    {
        
        private int MinimumTotal(IList<IList<int>> triangle, int i, int j, Dictionary<int, int> dict)
        {
            if (i == triangle.Count -1)
            {
                return triangle[i][j];
            }
            else
            {
                var key = 1000 * i + j;
                if (dict.ContainsKey(key))
                {
                    return dict[key];
                }
                else
                {
                    var v = triangle[i][j] + Math.Min(MinimumTotal(triangle, i + 1, j, dict), MinimumTotal(triangle, i + 1, j + 1,dict));
                    dict.Add(key, v);
                    return v;
                }                 
            }
        }
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            return MinimumTotal(triangle, 0, 0, dict);
        }
    }
}
