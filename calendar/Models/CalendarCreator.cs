using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calendar.Models;

namespace calendar.Models
{
    public class CalendarCreator
    {
        public DateTime myDate { get; set; }
        public DateTime dayOneDate { get; set; }

        public CalendarCreator(CurrentDateVM CDate)
        {
            myDate = CDate.myDate;
            dayOneDate = CDate.dayOneDate;
        }

        public CalendarVM create()
        {
            return new CalendarVM
            {
                year = myDate.Year,
                month = myDate.Month,
                day = myDate.Day,
                oneWeakDay = (int)dayOneDate.DayOfWeek,
                weakDay = (int)myDate.DayOfWeek
            };
        }
    }
}