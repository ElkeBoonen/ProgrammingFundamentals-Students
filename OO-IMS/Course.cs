using System;
using System.Collections.Generic;
using System.Text;

namespace OO_IMS
{
    public enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }

    class Course
    {
        public string Name { get; set; }
        public Teacher NameOfTeacher { get; set; }
        public string Room { get; set; }
        public int Hours { get; set; }
        public Time Start { get; set; }
        public WeekDays Weekday { get; set; }

        public Course(string n, Teacher t, string r, int h, Time s, WeekDays w )
        {
            Name = n;
            NameOfTeacher = t;
            Room = r;
            Hours = h;
            Start = s;
            Weekday = w;
        }

        public override string ToString()
        {
            string s = "";
            s += "OPO " + Name + "\n";
            s += NameOfTeacher.Name + "\n";
            s += Room + "\n";
            //Time eind = new Time(Start.Hours+Hours, Start.Minutes);
            Time eind = new Time(Start, Hours);
            s += Weekday + " van " + Start.ToString() + " tot " + eind.ToString();
            return s;
        }
    }
}
