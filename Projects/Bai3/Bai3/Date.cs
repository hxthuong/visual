using System;
using System.Collections.Generic;

namespace Bai3
{
    class Date
    {
        private int day, month, year;
        public Date(int year,int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public string DisplayStat()
        {
            return (year + "" + month + "" + day);
        }
    }
}
