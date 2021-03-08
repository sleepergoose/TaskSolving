using System;
using System.Linq;

namespace TaskSolving.Arrays
{
    public static class Others
    {
        // MaxSequenceSecond(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

        // Kadane’s Algorithm
        public static int MaxSequenceSecond(int[] arr)
        {
            int localMax = 0;
            int maxSum = 0;
            for (int i = 0, n = arr.Length; i < n; i++)
            {
                localMax = Math.Max(arr[i], arr[i] + localMax);
                if (localMax > maxSum)
                    maxSum = localMax;
            }
            return maxSum;
        }

        // Brute Force Approach
        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            int maxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum = 0;
                    for (int x = i; x <= j; x++)
                    {
                        sum += arr[x];
                    }
                    if (sum > maxSum)
                        maxSum = sum;
                }
            }
            return maxSum;
        }


        public static int[,] GenMultTable(int size)
        {
            var temp = Enumerable.Range(1, size).Select((p, i) =>
                Enumerable.Range(1, size).Select(x => (i + 1) * x)).ToArray();

            int[,] table = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    table[i, j] = temp[i].ToArray()[j];
                }
            }
            return table;
        }
    }
}
