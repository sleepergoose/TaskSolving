using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.Collections
{
    class Tasks
    {
        // The Supermarket Queue
        //long actual = QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);
        //long test2 = QueueTime(new int[] { }, 1);
        //long test3 = QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);
        public static long QueueTime(int[] customers, int n)
        {
            if (customers.Length == 0)
                return 0;
            if (n > customers.Length)
                return customers.Max();
            if (n == 1)
                return customers.Sum();

            Queue<int> queue = new Queue<int>(customers[n..]);
            List<int> temp = new List<int>(customers[0..n]);
            List<int> result = new List<int>();

            while (queue.Count != 0)
            {
                int min = temp.Min();
                result.Add(min);
                for (int i = 0; i < n; i++)
                {
                    if (temp[i] - min == 0 && queue.Count != 0)
                        temp[i] = queue.Dequeue();
                    else
                        temp[i] = temp[i] - min;
                }
            }
            return result.Sum() + temp.Max();
        }
    }
}
