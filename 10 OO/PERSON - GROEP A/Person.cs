using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_A
{
    class Person
    {
        public string Name { get; set; }
        protected DateTime Birth { get; set; }

        public Person()
        {
            Name = "Alex Van Mechelen";
            Birth = DateTime.Now;
        }

        public Person(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - Birth.Year;
            if (DateTime.Now.Month < Birth.Month)
            {
                age--;
            }
            else if (DateTime.Now.Month == Birth.Month && DateTime.Now.Day < Birth.Day)
            {
                age--;
            }
           return age;
        }

        public override string ToString()
        {
            return Name + " is " + Age() + " jaar oud.";
        }
    }
}
