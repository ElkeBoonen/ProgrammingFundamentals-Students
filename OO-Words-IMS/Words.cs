using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Words_IMS
{
    class Words
    {
        public string[] WordsArray { get; set; }

        public Words(string[] array)
        {
            WordsArray = array;
        }



        public string Sort()
        {
            Array.Sort(WordsArray);
            string s = "";
            foreach (var item in WordsArray)
            {
                s += item + " ";
            }
            return s.Trim();
        }

        public string MostOccurrences()
        {
            return "";
        }

        public string Occurrences()
        {
            string s = "";
            foreach (var item in WordsArray)
            {
                s += item + " ";
            }
            return s.Trim();
        }

        public string Unique()
        {
            return "";
        }

    }
    
}
