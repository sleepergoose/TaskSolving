using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.Other
{
    class Tasks
    {
        // Bouncing Balls
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
                return -1;
            int res = 1;
            while (h * bounce > window)
            {
                res += 2;
                h = h * bounce;
            }
            return res;
        }
    }
}
