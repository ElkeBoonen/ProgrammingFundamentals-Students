using System;
using System.Collections.Generic;
using System.Text;

namespace FRONTEND___DSPS
{
    class Artist
    {
        public int id { get; set; }
        public string name { get; set; }

        public Artist(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{id} - {name}";
        }
    }
}
