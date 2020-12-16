using System;
using System.Collections.Generic;
using System.Text;

namespace OO_DSPS
{
    class Student : Person
    {
        public List<Course> Courses { get; set; }

        public Student(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public Student(string name, DateTime birth, List<Course> courses)
        {
            Name = name;
            Birth = birth;
            Courses = courses;
        }

        public override string ToString()
        {
            string s = "STUDENT: " + Name + " - " + Birth.ToLongDateString();
            if (Courses != null)
            {
                s += "\nList of courses:\n";
                foreach (var item in Courses)
                {
                    s += "\n-" + item;
                }
            }
            return s;
        }
    }
}
