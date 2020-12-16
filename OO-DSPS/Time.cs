using System;
using System.Collections.Generic;
using System.Text;

namespace OO_DSPS
{
    class Time
    {
        int _hours;
        int _minutes;

        public int Hours {
            get 
            {
                return _hours;
            }
            set 
            {
                if (value >= 0 && value < 24) _hours = value;
                else _hours = 8;
            } 
        }
        public int Minutes {
            get 
            {
                return _minutes;
            }
            set 
            {
                if (value >= 0 && value < 60) _minutes = value;
                else _minutes = 30;
            } 
        }
        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time()
        {
            Hours = 8;
            Minutes = 30;
        }

        public Time(Time start, int addHours)
        {
            Hours = start.Hours + addHours;
            Minutes = start.Minutes;
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes;
        }
    }
}
