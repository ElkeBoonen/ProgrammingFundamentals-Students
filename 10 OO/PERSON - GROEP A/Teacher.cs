using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_A
{
    class Teacher : Person
    {
        public Teacher(string name, DateTime birth) : base(name, birth)
        {}

       /* zelfde functie als hierboven
        * public Teacher(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }*/

        public override string ToString()
        {
            return "TEACHER " + Name;
        }
    }
}
