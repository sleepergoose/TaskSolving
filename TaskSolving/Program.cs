using System;
using System.Linq;
using System.Collections.Generic;
//using TaskSolving.BinaryConvertion;
//using TaskSolving.Other;
//using TaskSolving.NumericalMiracles;
using TaskSolving.String;
using TaskSolving.Linq;
//using TaskSolving.Algorithms;
using System.Numerics;
using System.Text.RegularExpressions;

using System.Text;
//using System.Net;
//using System.Collections;
using System.Diagnostics;
using TaskSolving.OOP;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace TaskSolving
{
    public static class Program
    {
        static Action<object> Write = (text) => Console.WriteLine(text);

        static void Main(string[] args)
        {
            // xbonacci(new double[] { 2, 7, 19, 12, 5, 1, 18, 0, 4, 18 }, 27);
            //GenerateGroupings(new int[] { 0, 2, 3, 4, 5, 7, 8, 9, 11, 12, 14 });

           
            Write("");
        }



        public static string GenerateGroupings(int[] input)
        {
            Array.Sort(input);
            string res = input[0].ToString();
            int last = input[0];

            var ttt = input[1..].Where((p, index) => p - input[index] != 1);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - input[i - 1] == 1)
                {
                    if (i == input.Length - 1)
                        res += $"-{input[i]}";
                }
                else if(i == input.Length - 1 && input[i] - input[i - 1] == 1)
                {
                    res += $"-{input[i - 1]}";
                }
                else if(i == input.Length - 1 && input[i] - input[i - 1] != 1)
                {
                    res += $"-{input[i - 1]}, {input[i]}";
                }
                else
                {
                    res += $"-{input[i - 1]}, {input[i]}";
                }
            }

            return null;
        }

        public class MyComparer : IEqualityComparer<int>
        {

            public bool Equals([AllowNull] int x, [AllowNull] int y)
            {
                return Math.Abs(y - x) == 1;
            }

            public int GetHashCode([DisallowNull] int obj)
            {
                return obj.GetHashCode();
            }
        }


        public static double[] xbonacci(double[] signature, int n)
        {
            double[] res = new double[n];
            int len = signature.Length;
            double sum = signature.Sum();
            Array.Copy(signature, res, len);
            for (int i = len; i < n; i++)
            {
                res[i] = sum;
                sum = 2 * res[i] - res[i - len];
            }
            return res;
        }



        // 












        public static long SumOfTwoSumTargets(int[] numbers, int min, int max)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int sum = 0;
            for (int i = min; i < max; i++)
            {
                for (int j = 0, lim = numbers.Length; j < lim; j++)
                {
                    int dif = i - numbers[j];
                    if (numbers.Contains(dif) == true && dif != numbers[j])
                    {
                        sum += i;
                        break;
                    }
                }
            }
            //return sum;
            stopwatch.Stop();
            Console.WriteLine("time: " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("sum: " + sum);
            return sum;
        }
    }
}
