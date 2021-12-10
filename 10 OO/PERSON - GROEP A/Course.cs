using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_A
{
    class Course
    {
        public string Name { get; set; }
        public Teacher Docent { get; set; }
        public int Hours { get; set; }
        public Time Start { get; set; }
        public Weekday Day { get; set; }

        public Course(string name, Teacher docent, int hours, Time start, Weekday day)
        {
            Name = name;
            Docent = docent;
            Hours = hours;
            Start = start;
            Day = day;
        }

        public override string ToString()
        {
            string s = Name + "\n";
            s += " --> " + Docent.Name + "\n";
            Time End = Start.AddHours(this.Hours);
            s += " --> " + Day + " (" + Start + "-" + End +")";
            return s;

        }
    }
}
