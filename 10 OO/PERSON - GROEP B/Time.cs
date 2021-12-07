using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_B
{
    class Time
    {
        private int _minute;
        private int _hour;

        public int Hour
        {
            get { return _hour; }
            set {
                if (value < 0 || value >= 24) _hour = 0;
                else _hour = value;
            }
        }
        public int Minute 
        {
            get { return _minute; }
            set {
                if (value < 0 || value >= 60) _minute = 0;
                else _minute = value;
            }
        }

        public Time()
        {
            Hour = 0;
            Minute = 0;
        }

        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public Time AddHours(int hours)
        {
            return new Time(Hour + hours, Minute);
        }

        public override string ToString()
        {
            return Hour + ":" + Minute;
        }
    }
}
