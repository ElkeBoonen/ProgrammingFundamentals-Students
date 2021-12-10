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

        /*public Student(string name, DateTime birth, string school) : base(name,birth)
        {
            School = school;
        }*/

        public Student(string name, DateTime birth, string school)
        {
            Name = name;
            Birth = birth; 
            School = school;
        }

        //indien geen toString() dan neemt hij ToString() van Person!
        public override string ToString()
        {
            return "STUDENT " + Name + " volgt les op " + School;
        }

    }
}
