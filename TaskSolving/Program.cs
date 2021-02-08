using System;
using System.Linq;
using TaskSolving.BinaryConvertion;

namespace TaskSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 13;

            if ((num & 0b1) == 0)
                Console.WriteLine(Convert.ToString(num, 2)); 
            else
                Console.WriteLine(num.ToString("x"));


        }
    }
}
