using System;
using System.Linq;
using TaskSolving.BinaryConvertion;
using TaskSolving.Other;
using TaskSolving.NumericalMiracles;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Collections.Generic;





namespace TaskSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            // PascalsTriangle.GetSum(7, 0);

            //BinaryTree bt = new BinaryTree(21);

            //Console.WriteLine(BinaryTree.diagonal(17500, 201));
            Console.WriteLine(diagonal(17500, 201));
            //Console.WriteLine(BinaryTree.diagonal(20, 5));

            //Console.WriteLine(BinaryTree.diagonal(7, 0));
            //Console.WriteLine(BinaryTree.diagonal(7, 1));
            //Console.WriteLine(BinaryTree.diagonal(7, 2));
            //Console.WriteLine(BinaryTree.diagonal(7, 3));
            //Console.WriteLine(BinaryTree.diagonal(7, 4));
            //Console.WriteLine(BinaryTree.diagonal(7, 5));
            //Console.WriteLine(BinaryTree.diagonal(7, 6));
            //Console.WriteLine(BinaryTree.diagonal(7, 7));
        }
        public static BigInteger diagonal(int n, int p)
        {
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            n++;
            BigInteger sum = 0;
            for (BigInteger i = p + 1, k = 1; i <= n; i++)
            {
                sum += k;
                k = k * i / (i - p);
            }
            s.Stop();
            Console.WriteLine("timer: " + s.ElapsedMilliseconds);
            return sum;
        }




    }

    public class UrbanDictionary
    {
        private List<string> dict;
        public UrbanDictionary() => dict = new List<string>();

        public void AddWord(string word)
        {
            if (dict.Contains(word) == false)
                dict.Add(word);
        }

        public bool Search(string word)
        {
            var res = dict.Select(p => p).Where(p => p.Contains(word.Trim('.')));
            if (res.Count() != 0)
                return true;
            else
                return false;
        }

    }
}


/* 
 
   int number = 209917;

            var arr = number.ToString().ToCharArray();

            char min = arr.Min();
            int dest = 0, source = 0;
            if (arr[0] == min)
            {
                min = arr[1..arr.Length].Min();
                dest = 1;
            }
            for (int i = dest; i < arr.Length; i++)
            {
                if (arr[i] == min)
                    source = i;
            }

            for (int i = source; i > dest; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[dest] = min;
            long[] res;
            if (dest < 2 && source < 2)
                res =  new long[3] { long.Parse(string.Concat(arr)), dest, source };
            else
                res = new long[3] { long.Parse(string.Concat(arr)), source, dest };



            Console.WriteLine($"number: {number}");
            Console.WriteLine($"res: {string.Join("|", res)}");
 */