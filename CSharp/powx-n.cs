using System;
using System.Collections.Generic;
using System.Text;

namespace PowerN
{
    public class Solution
    {      
        private double MyPower(double x, int n, Dictionary<int, double> dict)
        {
            if (x == 0)
            {
                return 0;
            }

            if (x == 1)
            {
                return 1;
            }

            if (x == -1)
            {
                return n % 2 == 0 ? 1 : -1;
            }

            if (n == 0)
            {
                return 1;
            }

            if (n == 1)
            {
                return x;
            }

            if (n == -1)
            {
                return 1 / x;
            }

            if (dict.ContainsKey(n))
            {
                return dict[n];
            }

            double xn = 0;
            if (n % 2 == 0)
            {
                xn = MyPower(x, (int)(n / 2), dict) * MyPower(x, (int)(n / 2), dict);
                dict.Add(n, xn);               
            }
            else
            {
                xn = MyPower(x, (int)(n / 2), dict) * MyPower(x, n - (int)(n / 2), dict);
                dict.Add(n, xn);                
            }

            return xn;
        }
        public double MyPow(double x, int n)
        {
            var dict = new Dictionary<int, double>();
            return MyPower(x, n, dict); 
        }   
    }
}
