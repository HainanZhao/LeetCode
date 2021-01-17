using System;
using System.Collections.Generic;
using System.Text;

namespace Permutations
{
    public class Solution
    {
        IList<int> CloneList(IList<int> list)
        {
            var newList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
        IList<IList<int>> PermuteSingleList(IList<int> list, int extra)
        {
            var result = new List<IList<int>>();
            for (int i = 0; i < list.Count; i++)
            {
                var newList = CloneList(list);
                newList.Insert(i, extra);
                result.Add(newList);
            }

            var appendList = CloneList(list);
            appendList.Add(extra);
            result.Add(appendList);

            return result;
        }

        public IList<IList<int>> Permute(int[] nums)
        {

            var list = new List<IList<int>>();
            if (nums.Length == 0)
                return list;

            var length = nums.Length;
            var extra = nums[length - 1];


            if (nums.Length == 1)
            {
                list.Add(new List<int>() { extra });
                return list;
            }

            var childList = Permute(nums[0..(length - 1)]);
            foreach (var l in childList)
            {
                var lists = PermuteSingleList(l, extra);
                foreach (var newList in lists)
                {
                    list.Add(newList);
                }
            }

            return list;
        }
    }
}
