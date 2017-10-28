using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        private int hour;
        private int minute;
        public Time(int h =0, int m=0)
        {
            if (h < 0 || h > 23)
                hour = 0;
            else
                hour = h;
            if (m < 0 || m > 59)
                minute = 0;
            else
                minute = m;
        } 
        public Time(int m)
        {
            hour = m / 60;
            minute = m % 60;
        }
        public Time AddMinutes(int m)
        {
            m = minute + m;
            int h = hour + m / 60;
            m = m % 60;
            h = h % 12;
            return new Time(h, m);
        }
        public void PrintTime()
            {
            if (hour == 12 && minute == 0)
                Console.Write("noon");
            if (hour == 0 && minute == 0)
                Console.Write("midnight");
            bool isAM = true;
            int h = hour;
            if(hour>11)
            {
                h = hour % 12;
                isAM = false;
            }
            Console.Write("{0}:{1} {2}", h, minute, isAM ? "AM" : "PM");
        }
    }
}
