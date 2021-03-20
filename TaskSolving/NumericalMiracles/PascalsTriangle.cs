using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics;

namespace TaskSolving.NumericalMiracles
{

    public static class BinaryTree
    {
        private static ulong[][] arr;


        private static ulong[] Generate(int depth)
        {
            arr = new ulong[2][];
            int h = 0;
            for (int i = 1; i <= depth; i++)
            {
                arr[h] = new ulong[i + 1];
                arr[h][0] = arr[h][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    arr[h][j] = arr[h == 0 ? 1 : 0][j - 1] + arr[h == 0 ? 1 : 0][j];
                }
                h = ((h == 1) ? 0 : 1);
            }
            return arr[h == 0 ? 1 : 0];
        }

        public static BigInteger diagonal(int n, int p)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ulong res = Generate(n + 1)[p + 1];
            stopwatch.Stop();
            Console.WriteLine("time: " + stopwatch.ElapsedMilliseconds);
            return res;
        }
    }

    public static class Ext
    {
        public static ulong Sum(this ulong[] array)
        {
            ulong res = 0;
            foreach (var item in array)
            {
                res += (ulong)item;
            }
            return res;
        }
    }


    public static class PascalsTriangle
    {
        // C(p, n) = fact(n)/[fact(p) * fact(n - p)]

        public static BigInteger diagonal(int n, int p)
        {
            BigInteger res = new BigInteger(0);
            res = GetFactor(n + 1, p + 1);
            return res;
        }

        private static BigInteger GetFactor(int n, int p) =>
            Factorial(n) / (Factorial(p) * Factorial(n - p));

        //private static BigInteger Factorial(int z)
        //{
        //    BigInteger res = 1;
        //    if (z == 0)
        //        return 1;
            
        //    for (int i = 1; i <= z; i++)
        //        res *= i;
        //    return res;
        //}

        static BigInteger HalfProduct(int left, int right)
        {
            if (left > right)
                return 1;
            if (left == right)
                return left;
            if (right - left == 1)
                return (BigInteger)left * right;

            int m = (left + right) / 2;
            return HalfProduct(left, m) * HalfProduct(m + 1, right);
        }

        static BigInteger Factorial(int n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;

            return HalfProduct(2, n);
        }

        public static BigInteger diagonalNotMySolvingButFromCodewars(int n, int p)
        {
            n++;
            BigInteger sum = 0;
            for (BigInteger i = p + 1, k = 1; i <= n; i++)
            {
                sum += k;
                k = k * i / (i - p);
            }
            return sum;
        }
    }
}
