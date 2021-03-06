﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TaskSolving.NumericalMiracles
{
    public static class Tasks
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int res = p0, counter = 0;
            while (res < p)
            {
                res = (int)(res * (1 + percent / 100d) + aug);
                counter++;
            }
            return counter;
        }

        public static string WomensAge(int age)
        {
            return age % 2 == 0 ? $"{age}? That's just 20, in base {age / 2}!" : $"{age}? That's just 21, in base {(age - 1) / 2}!";
        }

        public static bool CommonOne(int a, int b) =>
            ((a & b) & ((a & b) - 1)) != 0;


        // Round to 0.5 step (4.3 to 4.5, 4.6 to 4.5, 4.8 to 5)
        public static double Solution(double n)
        {
            int integer = (int)n;
            double difference = n - integer;
            if (difference < 0.25)
                return integer;
            else if (difference >= 0.25 && difference < 0.75)
                return integer + 0.5;
            else
                return integer + 1;
        }


        // Lazy Repeater
        public static Func<char> makeLooper(string str)
        {
            int c = 0;
            return () => str[c++ % str.Length];

            int counter = 0;
            return () => {
                if (counter < str.Length)
                    return str[counter++];
                else
                {
                    counter = 0;
                    return str[counter++];
                }
            };
        }


        /* =========== */
        public static int Lcm(List<int> nums)
        {
            if (nums == null)
                return -1;
            if (nums.Count == 0)
                return 1;
            return nums.Aggregate((x, y) => LCM(x, y));
        }
        // The Greatest Common Devider
        private static int GCD(int a = 1, int b = 1)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }
        // The least Common Multiple [НОК(m, n) = (m · n) / НОД(m, n)]
        public static int LCM(int a = 1, int b = 1) => a * b / GCD(a, b);
        /* =========== */



         /* Check for PRIME */
        public static bool IsPrime(int n)
        {
            if (n != 2 && (n & 0b1) != 1 || n < 2)
                return false;
            for (int i = 3, lim = (int)Math.Sqrt(n); i <= lim; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }



        // Number Zoo Patrol
        // Recovery missed value in the sequences
        public static int FindNumber(int[] array)
        {
            if (array != null && array.Count() != 0)
            {
                Array.Sort(array);
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] - array[i - 1] != 1)
                        return array[i - 1] + 1;
                }
                return array[0] == 1 ? array[array.Length - 1] + 1 : 1;
            }
            else
                return 1;
        }



        // Twisted Sum
        // Sum digit, not a numbers
        public static long Solution(long n)
        {
            return Enumerable.Range(1, (int)n).Select(p => {
                if (p < 10)
                    return p;
                else
                    return p.ToString().Select(k => int.Parse(k.ToString())).Aggregate((x, y) => x + y);
            }).Sum();
        }
        public static long SolutionFromCommunity(long n)
        {
            var summe = 0;
            for (int i = 1; i <= n; i++)
                summe += i.ToString().Sum(CharUnicodeInfo.GetDigitValue);
            return summe;
        }



        // x2 - 4y2 = n
        // x = (a + b)/ 2  
        // y = (b - a)/ 4
        // x^2 - 4y^2 = n => ab = n
        public static string solEquaStr(long n)
        {
            List<string> res = new List<string>();
            for (int a = 1, lim = (int)Math.Sqrt(n) + 1; a < lim; a++)
            {
                long b, x, y;
                if ((n % a) == 0)
                {
                    b = (long)(n / a);
                    if ((b + a) % 2 == 0)
                    {
                        x = (b + a) / 2;
                        if ((b - a) % 4 == 0)
                        {
                            y = (b - a) / 4;
                            res.Add($"[{x}, {y}]");
                        }
                    }
                }
            }
            return res.Count > 0 ? $"[{string.Join(", ", res)}]" : "[]";
        }

        public static int find_it(int[] seq) =>
            seq.GroupBy(p => p).Where(m => m.Count() % 2 != 0).Select(k => k.Key).First();

        // Sum of Digits / Digital Root
        public static int DigitalRoot(long n)
        {
            if (n.ToString().Length == 1)
                return (int)n;
            int sum = n.ToString().Select(p => CharUnicodeInfo.GetDigitValue(p)).Sum();
            return DigitalRoot(sum);
        }

        // Persistent Bugger
        public static int Persistence(long n)
        {
            int counter = 0;
            while (n > 9)
            {
                n = n.ToString().Select(p => CharUnicodeInfo.GetDigitValue(p)).Aggregate((x, y) => x * y);
                counter++;
            }
            return counter;
        }


        // Go to the Cinema
        public static int Movie(int card, int ticket, double perc)
        {
            double sysA = 0;
            double sysB = card;
            int times = 0;
            double currentPrice = ticket;

            while (sysA <= sysB)
            {
                times++;
                sysA = ticket * times;
                currentPrice *= perc;
                sysB += currentPrice;
            }
            return times;
        }

        // PI approximation
        public static ArrayList iterPi(double epsilon)
        {
            int precision = (int)(1 / epsilon);
            int i = 1;
            double temp = 1d;
            double PI = 0;
            while (Math.Abs(Math.PI - PI) > epsilon)
            {
                if ((i & 0b1) == 1)
                    temp -= 1d / (2d * i + 1);
                else
                    temp += 1d / (2d * i + 1);
                PI = temp * 4d;
                i++;
            }

            return new ArrayList() { i, double.Parse(PI.ToString("F10")) };
        }
    }
}
