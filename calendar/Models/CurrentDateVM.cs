using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calendar.Models
{
    public class CurrentDateVM
    {
        public int year { get; set; } = DateTime.Now.Year;
        public int month { get; set; } = DateTime.Now.Month;
        public int day { get; set; } = DateTime.Now.Day;
        public DateTime dayOneDate
        {
            get
            {
                return new DateTime(year, month, 1);
            }
        }
        public DateTime myDate
        {
            get
            {
                return new DateTime(year, month, day);
            }
        }
    }
}