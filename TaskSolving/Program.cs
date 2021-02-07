using System;
using System.Linq;
using TaskSolving.BinaryConvertion;

namespace TaskSolving
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Net.IPAddress iPAddress = new System.Net.IPAddress(32);

            var res = string.Join(".", iPAddress.ToString().Split(".").Reverse());

            Console.WriteLine(res);
        }
    }
}
