using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calendar.Models;

namespace calendar.Models
{
    public class BigCalendar
    {
        public CalendarVM calendar { get; set; }
        public int prevMonth
        {
            get
            {
                if (calendar.month == 1)
                {
                    return 12;
                }
                return calendar.month - 1;
            }
        }
        public int prevYear
        {
            get
            {
                if (prevMonth == 12)
                {
                    return calendar.year - 1;
                }
                return calendar.year;
            }
        }
        public int nextMonth
        {
            get
            {
                if (calendar.month == 12)
                {
                    return 1;
                }
                return calendar.month + 1;
            }
        }
        public int nextYear
        {
            get
            {
                if (nextMonth == 1)
                {
                    return calendar.year + 1;
                }
                return calendar.year;
            }
        }
    }
}