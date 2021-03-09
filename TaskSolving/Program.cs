using System;
using System.Linq;
//using TaskSolving.BinaryConvertion;
//using TaskSolving.Other;
//using TaskSolving.NumericalMiracles;
using TaskSolving.String;
using TaskSolving.Linq;
//using TaskSolving.Algorithms;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
//using System.Net;
//using System.Collections;
using System.Diagnostics;



namespace TaskSolving
{
    public static class Program
    {

        static Action<object> Write = (text) => Console.WriteLine(text);

        static void Main(string[] args)
        {
            //var arr1 = new[] { 5, 4, 3, 2, 1 };
            //var arr2 = new[] { 1, 2, 3, 1, 2 };
            //var arr3 = new[] { 1, 2, 3, -4, 0 };

            //var res = FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 3);
            //res = FirstNSmallest(new[] { 5, 4, 3, 2, 1 }, 3);
            //res = FirstNSmallest(new[] { 1, 2, 3, 1, 2 }, 3);

            Random rnd = new Random();
            var array = Enumerable.Range(0, 100000).Select(p => p = rnd.Next(0, 3)).ToArray();

            MoveZeroes2(array);
        }

        public static int[] MoveZeroes2(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int zeros = arr.Count(p => p == 0);
            var result = arr.Where(p => p != 0).ToList();
            for (int i = 0; i < zeros; i++)
                result.Add(0);
            var rs = result.ToArray();
            sw.Stop();
            Write(sw.ElapsedMilliseconds);
            return rs;
        }

        public static int[] MoveZeroes(int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (arr[i - 1] == 0 && arr[i] != 0)
                        (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                }
            }
            sw.Stop();
            Write(sw.ElapsedMilliseconds);
            return arr;
        }






        public static int[] FirstNSmallest(int[] arr, int n)
        {
            
            return new int[] { };
        }











    }
}
