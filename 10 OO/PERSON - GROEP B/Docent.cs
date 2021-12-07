using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON___GROEP_B
{
    class Docent : Person
    {
        public Docent(string name, DateTime birthday): base(name, birthday)
        {}

        public override string ToString()
        {
            return "DOCENT " + base.ToString();
        }
    }
}
