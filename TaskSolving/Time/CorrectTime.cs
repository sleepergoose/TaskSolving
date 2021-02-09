using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskSolving.Time
{
    public static class CorrectTime
    {
        public static string Correct(string timeString)
        {
            Regex regex = new Regex(@"\d{2}:\d{2}:\d{2}");

            if (timeString == null)
                return null;
            if (timeString == string.Empty)
                return string.Empty;
            if (regex.IsMatch(timeString) == false)
                return null;


            var res = timeString.Split(":");

            int secs = int.Parse(res[2]);
            int mins = int.Parse(res[1]);
            int hours = int.Parse(res[0]);

            if (secs > 59)
            {
                secs = secs - 60;
                mins = mins + 1;
            }
            if (mins > 59)
            {
                mins = mins - 60;
                hours += 1;
            }
            if (hours > 23)
            {
                hours = hours % 24;
            }

            return $"{hours.ToString("0#")}:{mins.ToString("0#")}:{secs.ToString("0#")}";
        }
    }
}
