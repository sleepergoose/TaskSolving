using System;
using System.Collections.Generic;
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


        // Moving Zeros To The End
        public static int[] MoveZeroes2(int[] arr)
        {
            int zeros = arr.Count(p => p == 0);
            var result = arr.Where(p => p != 0).ToList();
            for (int i = 0; i < zeros; i++)
                result.Add(0);
            return result.ToArray();
            // from Codewars' community
            return arr.OrderBy(x => x == 0).ToArray();
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

        public static int[] PartsSums(int[] ls)
        {
            // var res = Enumerable.Range(0, ls.Length + 1).Select(p => ls[p..ls.Length].Sum()).ToArray();
            int sum = ls.Sum();
            var res = new List<int>();
            res.Add(sum);
            foreach (var item in ls)
            {
                sum -= item;
                res.Add(sum);
            }
            return res.ToArray();
        }

        // Make the Deadfish swim
        public static int[] Parse(string data)
        {
            int number = 0;
            List<int> result = new List<int>();
            foreach (char item in data)
            {
                switch (item)
                {
                    case 'i':
                        number++;
                        break;
                    case 'd':
                        number--;
                        break;
                    case 's':
                        number = (int)Math.Pow(number, 2);
                        break;
                    case 'o':
                        result.Add(number);
                        break;
                    default:
                        break;
                }
            }
            return result.ToArray();
        }


        // Mean Square Error
        public static double Solution(int[] firstArray, int[] secondArray) =>
            firstArray.Select((p, index) => Math.Pow(p - secondArray[index], 2)).Average();


        // N smallest elements in original order
        public static int[] FirstNSmallest(int[] arr, int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int min = arr.Min();
                int index = Array.IndexOf(arr, min);
                dict.Add(index, min);
                arr[index] = int.MaxValue;
            }
            return dict.OrderBy(p => p.Key).Select(p => p.Value).ToArray();
        }
    }
}
