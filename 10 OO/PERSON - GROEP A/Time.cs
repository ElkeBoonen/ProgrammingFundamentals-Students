using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_A
{
    class Time
    {
        private int _hours;
        private int _minutes;
        public int Hours { 
            get {
                return _hours;
            }
            set {
                if (value >= 0 && value <= 23)
                {
                    _hours = value;
                }
                else _hours = 8;
            } 
        }
        public int Minutes {
            get {
                return _minutes;
            }
            set {
                if (value >= 0 && value <= 59)
                {
                    _minutes = value;
                }
                else _minutes = 30;
            } 
        }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time AddHours(int hours)
        {
            Time t = new Time(this.Hours, this.Minutes);
            t.Hours += hours;
            return t;
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes;
        }


    }
}
