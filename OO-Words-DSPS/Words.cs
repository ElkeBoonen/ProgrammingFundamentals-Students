using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Words_DSPS
{
    class Words
    {
        //THINK OF DICTIONARIES
        public string[] ArrayOfWords { get; set; }

        public Words(string[] array)
        {
            ArrayOfWords = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                ArrayOfWords[i] = array[i];
            }
        }

        public string Sort()
        {
            List<string> list = new List<string>();
            list.AddRange(ArrayOfWords);
            list.Sort();
            string sorted = "";
            foreach (var item in list)
            {
                sorted += item + " ";
            }
            return sorted.Trim();
        }

        public string Occurrences()
        {
            return "";
        }

        public string Unique()
        {
            return "";
        }

        public string MostOccurrences()
        {
            return "";
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in ArrayOfWords)
            {
                str += item + " ";
            }
            return str.Trim();
        }

    }
}
