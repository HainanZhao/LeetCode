using System;
using System.Collections.Generic;
using System.Text;

namespace SetMatrixZeros
{
    public class Solution
    {
       
        public void SetZeroes(int[][] matrix)
        {
            var xNulls = new HashSet<int>();
            var yNulls = new HashSet<int>();

            for (int i = 0; i < matrix.Length; i++)
            {                
                var zeroFound = false;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!zeroFound)
                        {
                            xNulls.Add(i);
                            zeroFound = true;
                        }
                        yNulls.Add(j);                        
                    }
                }                                      
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                var zeroX = xNulls.Contains(i);
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    var zeroY = yNulls.Contains(j);
                    if (zeroX || zeroY)
                    {
                        matrix[i][j] = 0;
                    }                    
                }
            }
        }
    }
}
