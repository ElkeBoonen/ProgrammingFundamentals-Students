using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HARRY_POTTER_CHARACTERS___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het gewenste huis in: ");
            string house = Console.ReadLine();

            //Slytherin Ravenclaw Gryffindor Hufflepuff

            foreach (string line in File.ReadLines("Characters.csv"))
            {
                if (line.Contains(house))
                {
                    //1;Harry James Potter;Male; 
                    int index = line.IndexOf(";"); //eerste index zoeken
                    string substring = line.Substring(index+1); //afknippen
                    //Harry James Potter;Male; 
                    index = substring.IndexOf(";");
                    substring = substring.Substring(0, index);
                    //Harry James Potter
                    Console.WriteLine(substring);

                }
            }

            //alle jaartallen eruit halen!!
            Regex regex = new Regex(@"\d{4}");
            MatchCollection matches = regex.Matches(File.ReadAllText("Characters.csv"));
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
