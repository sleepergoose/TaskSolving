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

            var res = Rot13("This is my first ROT13 excercise!");
            Write(res);
        }

        public static string Rot13(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (char.IsUpper(input[i]))
                        sb.Append((char)((input[i] + 13) % (input[i] + 26)));
                    else
                        sb.Append((char)((input[i] + 13) % (input[i] + 26)));
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }


        public static string Rot132(string message)
        {
            //
            string res = "";
            message.ToList().ForEach(c => {
                if (char.IsLetter(c))
                    res += ((char)((c + 13) % (c + 26)));
                else
                    res += (char)c;
            });
            return res;
        }











        public static int[] FirstNSmallest(int[] arr, int n)
        {
            
            return new int[] { };
        }











    }
}
