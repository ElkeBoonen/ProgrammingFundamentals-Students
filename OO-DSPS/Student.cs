using System;
using System.Collections.Generic;
using System.Text;

namespace OO_DSPS
{
    class Student : Person
    {
        public Student(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public override string ToString()
        {
            return "STUDENT: " + Name + " - " + Birth.ToLongDateString();
        }
    }
}
