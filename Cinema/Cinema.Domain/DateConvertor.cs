using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain
{
    public static class DateConvertor
    {
        public static string DateString(DateTime date)
        {
            return date.Year + "-" + date.Month.ToString("00") + "-" + date.Day.ToString("00");
        }
    }
}
