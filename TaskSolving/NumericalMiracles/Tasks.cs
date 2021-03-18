using System;
using System.Collections.Generic;
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
    }
}
