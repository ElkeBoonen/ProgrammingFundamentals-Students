using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_B
{
    class Student : Person
    {
        public List<Course> Courses { get; set; }

        public Student(string name, DateTime birthday) : base(name,birthday)
        {
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            //return "STUDENT " + base.ToString();
            //return ;

            string s = "STUDENT " + Name + " is " + Age() + " years old\n";
            foreach (var item in Courses)
            {
                s += "** " + item + "\n";
            }
            return s;
        }
    }
}
