using System;
using System.Collections.Generic;
using System.Text;

namespace OO_IMS
{
    class Student : Person
    {
        public List<Course> Courses { get; set; }
        public Student(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
            Courses = new List<Course>();
        }

        public Student(string name, DateTime birth, List<Course> courses)
        {
            Name = name;
            Birth = birth;
            Courses = courses;
        }

        public override string ToString()
        {
            string s = "STUDENT " + Name + " is " + Age() + " jaar oud";
            s += "\n--LIJST CURSUSSEN";
            foreach (var item in Courses)
            {
                s += "\n-" + item.ToString();
            }
            return s;

        }
    }
}
