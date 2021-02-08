using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.Other
{
    public static class QueueForBills
    {
       public static string ThereIsChange(int[] array)
       {
            int _25bill = 0;
            int _50bill = 0;
            int _100bill = 0;
            int change = 0;

            foreach (var cash in array)
            {
                if (cash == 25)
                {
                    _25bill++;
                    continue;
                }
                else if (cash == 50)
                {
                    _50bill++;
                }
                else if (cash == 100)
                {
                    _100bill++;
                }

                change = cash - 25;

                if (change >= 100 && _100bill > 0)
                {
                    change -= 100;
                    _100bill--;
                }
                if(change >= 50 && _50bill > 0)
                {
                    change -= 50;
                    _50bill--;
                }
                if (change >= 25 && _25bill > 0)
                {
                    change -= 25;
                    _25bill--;
                }

                if(change > 0)
                    return "NO";              
            }
            return "YES";
       }
    }
}

// new int[] { 25, 25, 50 } };
// new int[] { 25, 100 } };
// new int[] { 25, 25, 50, 50, 100 } };
