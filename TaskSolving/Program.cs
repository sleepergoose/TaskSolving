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
//using System.Net;
//using System.Collections;




namespace TaskSolving
{
    public static class Program
    {

        static Action<object> Write = (text) => Console.WriteLine(text);

        static void Main(string[] args)
        {
            int r = 42145;

            Write(OddOrEven);

        }


        public static string OddOrEven(int[] array) =>
            (array.Sum() & 0b1) == 1 ? "odd" : "even";
        














    }
}
