using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.Delegates
{
    public class Calc
    {
        // Two(Plus(One())) => Calculating with Functions
        public static int Sub(int num, Func<int, int> func) => func == null ? num : func(num);

        public static Func<int, int> Plus(int right) => (left) => left + right;
        public static Func<int, int> Minus(int right) => (left) => left - right;
        public static Func<int, int> Times(int right) => (left) => left * right;
        public static Func<int, int> Divide(int right) => (left) => left / right;


        public static int Zero(Func<int, int> func = null) => Sub(0, func);
        public static int One(Func<int, int> func = null) => Sub(1, func);
        public static int Two(Func<int, int> func = null) => Sub(2, func);
        public static int Three(Func<int, int> func = null) => Sub(3, func);
        public static int Four(Func<int, int> func = null) => Sub(4, func);
        public static int Five(Func<int, int> func = null) => Sub(5, func);
        public static int Six(Func<int, int> func = null) => Sub(6, func);
        public static int Seven(Func<int, int> func = null) => Sub(7, func);
        public static int Eight(Func<int, int> func = null) => Sub(8, func);
        public static int Nine(Func<int, int> func = null) => Sub(9, func);
    }
}
