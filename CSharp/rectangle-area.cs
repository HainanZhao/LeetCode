using System;
using System.Collections.Generic;
using System.Text;

namespace RectaguleArea
{
    public class Solution
    {
        private int CalculateRecArea(int A, int B, int C, int D)
        {
            return (C - A) * (D - B);
        }

        private Tuple<int, int, int, int> FindCommonRec(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            int xl=0, yl=0, xr=0, yr=0;
            if (C >= E && A <= G && D >= F && B <= H)
            {
                xl = Math.Max(A, E);
                xr = Math.Min(C, G);
                yl = Math.Max(B, F);
                yr = Math.Min(D, H);
            }

            return new Tuple<int, int, int, int>(xl, yl, xr, yr);
        }
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            var common = FindCommonRec(A, B, C, D, E, F, G, H);

            return CalculateRecArea(A, B, C, D) + CalculateRecArea(E, F, G, H) - CalculateRecArea(common.Item1, common.Item2, common.Item3, common.Item4);
        }
    }
}
