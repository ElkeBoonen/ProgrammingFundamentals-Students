using System;
using System.Collections.Generic;
using System.Text;

namespace OO_DSPS
{
    enum WeekDays
    { 
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saterday = 5,
        Sunday = 6
    }

    class Course
    {
        public string Name { get; set; }
        public Teacher NameTeacher { get; set; }
        public string Room { get; set; }

        public int Hours { get; set; }

        public WeekDays Weekday { get; set; }

        public Time Start { get; set; }

        public Course(string name, Teacher teacher, string room, int hours, WeekDays day, Time start)
        {
            Name = name;
            NameTeacher = teacher;
            Room = room;
            Hours = hours;
            Weekday = day;
            Start = start;
        }

        public override string ToString()
        {
            string s = "";
            s += "COURSE " + Name;
            s += "\n" + NameTeacher.Name;
            s += "\n" + Room;
            Time end = new Time(Start, Hours);
            s += "\n" + Weekday + " from " + Start + " to " + end; //Wednesday from 8:30 to 11:30

            //s += "\n" + Weekday + " from " + Start + "to" + (Start.Hours+Hours) + ":" + Start.Minutes;
            return s;

        }

    }
}
