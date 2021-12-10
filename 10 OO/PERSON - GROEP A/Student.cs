using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_A
{
    class Student : Person
    {
        public string School { get; set; }
        public List<Course> Courses { get; set; }

        /*public Student(string name, DateTime birth, string school) : base(name,birth)
        {
            School = school;
        }*/

        public Student(string name, DateTime birth, string school, List<Course> courses)
        {
            Name = name;
            Birth = birth; 
            School = school;
            Courses = courses;
        }

        //indien geen toString() dan neemt hij ToString() van Person!
        public override string ToString()
        {
            string s = "STUDENT " + Name + " volgt les op " + School + "\n";
            foreach (var item in Courses)
            {
                s += "*" + item + "\n";
            }
            return s;
        }

    }
}
