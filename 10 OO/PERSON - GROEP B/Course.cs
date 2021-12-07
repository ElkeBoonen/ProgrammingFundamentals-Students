using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_B
{
    class Course
    {
        public string Name { get; set; }
        public Docent Teacher { get; set; }
        public int Hours { get; set; }
        public Time Start { get; set; }
        public Weekday Day { get; set; }

        public Course(string name, Docent teacher, int hours, Time start, Weekday day)
        {
            Name = name;
            Teacher = teacher;
            Hours = hours;
            Start = start;
            Day = day;
        }

        public override string ToString()
        {
            string s = "";
            s += Name.ToUpper() + "\n";
            s += " by " + Teacher.Name + "\n";
            s += " on " + Day + " --> " + Start + "-" + Start.AddHours(Hours);
            return s;

        }
    }
}
