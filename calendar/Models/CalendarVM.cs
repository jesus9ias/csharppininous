using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace calendar.Models
{
    public class CalendarVM
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int oneWeakDay { get; set; }
        public int weakDay { get; set; }
        public int monthDays
        {
            get
            {
                return DateTime.DaysInMonth(year, month);
            }
        }
    }
}