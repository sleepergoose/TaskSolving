using System;
using System.Collections.Generic;
using System.Linq;
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



        // Did I Finish my Sudoku?
        //var arr = new int[][]
        //{
        //     new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
        //     new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
        //     new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
        //     new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
        //     new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
        //     new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
        //     new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
        //     new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
        //     new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
        //};
        public static string DoneOrNot(int[][] board)
        {
            foreach (var item in board)
            {
                if (item.Distinct().Count() != 9)
                    return "Try again!";
            }

            for (int j = 0; j < 9; j++)
            {
                List<int> col = new List<int>(9);
                for (int i = 0; i < 9; i++)
                    col.Add(board[i][j]);
                if (col.Distinct().Count() != 9)
                    return "Try again!";
            }

            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    List<int> area = new List<int>(9);
                    for (int j = 0; j < 3; j++)
                    {
                        area.AddRange(board[j + 3 * k][(3 * i)..(3 * i + 3)]);
                    }
                    if (area.Distinct().Count() != 9)
                        return "Try again!";
                }
            }

            return "Finished!";
        }
    }
}
