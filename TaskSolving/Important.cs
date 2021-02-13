using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving
{
    public static class Important
    {
        public static void Summary()
        {
            char[] arr = "123".ToCharArray();

            // Gets index of elements
            Array.IndexOf(arr, '1');

            // Gets the numeric value of char
            char.GetNumericValue(arr[0]);
            char.GetNumericValue("123", 0);

            
        }
    }
}
