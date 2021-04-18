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
using System.Collections;
using System.IO;
using static TaskSolving.Delegates.Calc;

namespace TaskSolving
{
    public static class Program
    {
        static Action<object> Write = (text) => Console.WriteLine(text);

        static void Main(string[] args)
        {

            Write("");
        }



        public static bool ValidateString(string[] dictionary, string word)
        {
            string str = word;
            foreach (var item in dictionary)
            {
                Regex regex = new Regex(@$"{item}");
                str = regex.Replace(str, string.Empty);
                if (str == "")
                {
                    Console.WriteLine("true");
                    return true;
                }
            }
            
            Console.WriteLine("false");
            return false;
        }



        public static List<string> GetPINs(string observed)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>()
            {
                ["0"] = new List<string>() { "0", "8" },
                ["1"] = new List<string>() { "1", "2", "4" },
                ["2"] = new List<string>() { "2", "1", "3", "5" },
                ["3"] = new List<string>() { "3", "2", "6" },
                ["4"] = new List<string>() { "4", "1", "5", "7" },
                ["5"] = new List<string>() { "5", "2", "4", "6", "8" },
                ["6"] = new List<string>() { "6", "3", "5", "9" },
                ["7"] = new List<string>() { "7", "4", "8" },
                ["8"] = new List<string>() { "8", "0", "5", "7", "9" },
                ["9"] = new List<string>() { "9", "6", "8" }
            };

            string num = "1357";

            for (int i = 0; i < 4; i++)
            {

            }

            return null;
        }

        



        public static BigInteger GetNthReverseNumber(long num)
        {
            if (num <= 9)
                return num;
            // 2 digit
            else if (num > 9 & num < 19)
            {
                var dig = char.GetNumericValue(num.ToString()[1]) + 1;
                return long.Parse($"{dig}{dig}");
            }
            // 3 digit
            else if (num >= 19 & num < 109)
            {
                var digMiddle = (num + 1).ToString().Last();
                var digMargin = int.Parse((num + 1).ToString()[..^1]) - 1;
                return long.Parse($"{digMargin}{digMiddle}{digMargin}");
            }
            // 4 digit
            else if (num >= 109 & num <= 999)
            {
                string dig = (num + 1).ToString();
                return long.Parse($"{dig[1..]}{string.Concat(dig[1..].Reverse())}");
            }
            return -1;
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
