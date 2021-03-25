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

namespace TaskSolving
{
    public static class Program
    {
        static Action<object> Write = (text) => Console.WriteLine(text);

        static void Main(string[] args)
        {
            // xbonacci(new double[] { 2, 7, 19, 12, 5, 1, 18, 0, 4, 18 }, 27);
            
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
