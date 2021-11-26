using System;
using System.Text.RegularExpressions;

namespace Most_Occuring
{
    class Program
    {
        /*
         lees reeks woorden in, zoek het meest voorkomende woord
         */
        static void Main(string[] args)
        {
            string input = "appel banaan appel citroen appel"; //Console.ReadLine();
            string[] words = input.Split(' ');

            int most = 0;
            string word = "";
            int counter = 0;
            foreach (var item in words)
            {
                counter = 0;
                foreach (var w in words)
                {
                    if (item == w)
                    { 
                        counter++;
                    }
                }
                if (counter > most)
                {
                    word = item;
                    most = counter;
                }
            }
            Console.WriteLine(word);


            //REGEX-OPLOSSING
            most = 0;
            word = "";
            foreach (var item in words)
            {
                Regex regex = new Regex(item);
                if (regex.Matches(input).Count > most)
                {
                    most = regex.Matches(input).Count;
                    word = item;
                }
            }
            Console.WriteLine(word);

            //bubble sort
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length-1; j++)
                {
                    if (words[j].CompareTo(words[j + 1]) > 0) //String.Compare(array[j], array[j+1])
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            most = 0;
            word = "";
            counter = 0;
            for (int i = 0; i < words.Length-1; i++)
            {
                if (words[i].CompareTo(words[i + 1]) == 0)
                {
                    counter++;
                }
                else
                {
                    if (counter > most)
                    {
                        most = counter;
                        word = words[i];
                    }
                    counter = 0;
                }
            }
            Console.WriteLine(word);
        }
    }
}
