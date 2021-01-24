using System;
using System.Collections.Generic;
using System.Text;

namespace MinimumKnightsMoves
{
    class minimum_knight_moves
    {
        public class Solution
        {
            void Init(int[,] dict)
            {
                dict[0, 0] = 0;
                dict[0, 1] = 3;
                dict[0, 2] = 2;
                dict[1, 0] = 3;
                dict[1, 1] = 2;
                dict[1, 2] = 1;
                dict[2, 0] = 2;
                dict[2, 1] = 1;
                dict[2, 2] = 4;
            }

            int MinSteps(int[,] dict, int x, int y)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);

                if (x == 0 && y == 0)
                    return 0;

                if (dict[x, y] != 0)
                    return dict[x, y];
                else
                {
                    dict[x, y] = Math.Min(MinSteps(dict, x - 1, y - 2) + 1, MinSteps(dict, x - 2, y - 1) + 1);
                    return dict[x, y];
                }
            }

            public int MinKnightMoves(int x, int y)
            {
                var dict = new int[Math.Max(3, Math.Abs(x) + 1), Math.Max(3, Math.Abs(y) + 1)];
                Init(dict);

                return MinSteps(dict, x, y);
            }
        }
    }
}
