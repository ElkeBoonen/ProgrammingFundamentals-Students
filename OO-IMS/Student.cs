using System;
using System.Collections.Generic;
using System.Text;

namespace OO_IMS
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
            return "STUDENT " + Name + " is " + Age() + " jaar oud"; ;
        }
    }
}
