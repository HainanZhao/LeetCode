using System;
using System.Collections.Generic;
using System.Text;

namespace EditDistance
{
    public class Solution
    {
        int MinDistance(char[] chars1, char[] chars2, int i, int j, int[,] dict)
        {
            //Edge conditions
            if (i == -1 && j == -1)
                return 0;
            else if (i == -1 && j >= 0)
                return j + 1;
            else if (i >= 0 && j == -1)
                return i + 1;

            if (dict[i,j] > -1)
                return dict[i, j];

            int distance;
            var i_j_ = MinDistance(chars1, chars2, i - 1, j - 1, dict);

            //If last char is the same, MinDistance will be the same as if truncate the last char for both strings.
            if (chars1[i] == chars2[j])
            {
                distance = i_j_;
            }
            //Otherwise, it will the MinDistance of all 3 operations + 1;
            else
            {
                var i_j = MinDistance(chars1, chars2, i - 1, j, dict);
                var ij_ = MinDistance(chars1, chars2, i, j - 1, dict);

                distance = Math.Min(i_j_, Math.Min(i_j, ij_)) + 1;
            }

            //Console.WriteLine($"{i} {j} {new string(chars1[0..(i+1)])} {new string(chars2[0..(j+1)])} : {distance} ");
            dict[i,j] = distance;
            return distance;
        }
        public int MinDistance(string word1, string word2)
        {
            var chars1 = word1.ToCharArray();
            var chars2 = word2.ToCharArray();
            var dict = new int[chars1.Length, chars2.Length];
            for(int i =0; i< chars1.Length; i++)
                for(int j= 0; j< chars2.Length; j++)
                    dict[i, j] = -1;

            return MinDistance(chars1, chars2, chars1.Length - 1, chars2.Length - 1, dict);
        }
    }
}
