using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_B
{
    class Student : Person
    {
        public Student(string name, DateTime birthday) : base(name,birthday)
        {}

        public override string ToString()
        {
            //return "STUDENT " + base.ToString();
            return "STUDENT " + Name + " is " + Age() + " years old";
        }
    }
}
