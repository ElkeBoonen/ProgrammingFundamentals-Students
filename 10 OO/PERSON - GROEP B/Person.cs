using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_B
{
    class Person
    {
        public string Name { get; set; }
        private DateTime Birthday { get; set; }

        public Person()
        {
            Name = "Sam Van Mechelen";
            Birthday = DateTime.Now;
        }

        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - Birthday.Year;

            if (now.Month < Birthday.Month) age--;
            else if (now.Month == Birthday.Month && now.Day < Birthday.Day) age--;
          
            return age;
        }

        public override string ToString()
        {
            return Name + " is " + Age() + " years old";
        }
    }
}
