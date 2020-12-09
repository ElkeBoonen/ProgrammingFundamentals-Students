using System;
using System.Collections.Generic;
using System.Text;

namespace OO_DSPS
{
    class Teacher : Person
    {
        public Teacher(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public override string ToString()
        {
            return "TEACHER: " + Name + " - " + Birth.ToLongDateString();
        }
    }
}
