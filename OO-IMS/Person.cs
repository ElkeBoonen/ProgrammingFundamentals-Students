using System;
using System.Collections.Generic;
using System.Text;

namespace OO_IMS
{
    public class Person
    {
        public string Name { get; set; }
        private DateTime Birth { get; set; }

        public Person()
        {
            Name = "John Doe";
            Birth = new DateTime(2000,1,1);
        }

        public Person(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }
    }
}
