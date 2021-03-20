using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.Matrix
{
    class Matrix
    {
        /* Matrix Multiple */
        public static int[,] MatrixMultiplication(int[,] a, int[,] b)
        {
            int rows = a.GetUpperBound(0) + 1;
            int cols = a.Length / rows;
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var temp = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }
                    result[i, j] = temp;
                }
            }
            return result;
        }


        // Adding Matrix
        public static int[][] MatrixAddition(int[][] a, int[][] b)
        {
            var res = new int[a.Length][];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = new int[a[i].Length];
                for (int j = 0; j < a[i].Length; j++)
                {
                    res[i][j] = a[i][j] + b[i][j];
                }
            }
            return res;
        }
        // return a.Zip(b, (ax, bx) => ax.Zip(bx, (i, j) => i + j).ToArray()).ToArray();
        // return a.Select((r, i) => r.Select((n, j) => n + b[i][j]).ToArray()).ToArray();
    }
}
