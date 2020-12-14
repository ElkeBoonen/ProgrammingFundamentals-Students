using System;
using System.Collections.Generic;
using System.Text;

namespace OO_IMS
{
    public class Time
    {
        //Time t = new Time(13,45)
        //Console.WriteLine(t.Hours);
        //t.Minutes = 00;

        private int _hours;
        private int _minutes;
        public int Hours { 
            get {
                return _hours;
            } 
            set {
                if (value >= 0 && value < 24) _hours = value;
                else _hours = 8;
            } 
        }
        public int Minutes { 
            get {
                return _minutes;    
            } 
            set {
                if (value >= 0 && value < 60) _minutes = value;
                else _minutes = 30;
            } 
        }

        public Time()
        {
            Hours = 8;
            Minutes = 30;
        }

        public Time(int hours, int min)
        {
            Hours = hours;
            Minutes = min;
        }

        public Time(Time t, int add)
        {
            Hours = t.Hours + add;
            Minutes = t.Minutes;
        }

        public override string ToString()
        {
            return Hours +":" + Minutes;
        }

      
    }
}
