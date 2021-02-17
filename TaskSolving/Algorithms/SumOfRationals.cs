using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.Algorithms
{
    public class SumOfRationals
    {
        List<NumericFraction> NumericFractionsList;

        public SumOfRationals(int[,] array)
        {
            if (array.Length == 0)
                NumericFractionsList = null;
            else
            {
                NumericFractionsList = new List<NumericFraction>();
                int rows = array.GetUpperBound(0);

                for (int i = 0; i < rows + 1; i++)
                {
                    NumericFractionsList.Add(new NumericFraction(array[i, 0], array[i, 1]));
                }
            }
        }

        public string GetSumOfFractions()
        {
            if (NumericFractionsList == null)
                return null;

            int maxDenominator = NumericFractionsList.Max(p => p.Denominator);
            
            int commonDenominator = maxDenominator;
            while (!Check(commonDenominator))
                commonDenominator += maxDenominator;

            NumericFractionsList.ForEach(p => p.SetCommonDenom(commonDenominator));
            int sumOfNumerators = NumericFractionsList.Sum(p => p.Numerator);

            int commonDevider = GetSmalestCommonDevider(sumOfNumerators, commonDenominator);
            sumOfNumerators = sumOfNumerators / commonDevider;
            commonDenominator = commonDenominator / commonDevider;

            return (commonDenominator == 1) ? $"{sumOfNumerators}" : $"[{sumOfNumerators}, {commonDenominator}]";
        }

        int GetSmalestCommonDevider(int x, int y)
        {
            while (y != 0)
            {
                int t = y;
                y = x % y;
                x = t;
            }
            return x;
        }

        bool Check(int number)
        {
            return NumericFractionsList.Count(p => number % p.Denominator != 0) == 0 ? true : false;
        }
    }


    public class NumericFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public NumericFraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void SetCommonDenom(int CommonDenom)
        {
            this.Numerator = this.Numerator * CommonDenom / this.Denominator;
            this.Denominator = CommonDenom;
        }
    }
}

