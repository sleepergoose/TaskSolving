using System;
using System.Linq;
using TaskSolving.BinaryConvertion;
using TaskSolving.Other;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskSolving
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }


 
    }
}
