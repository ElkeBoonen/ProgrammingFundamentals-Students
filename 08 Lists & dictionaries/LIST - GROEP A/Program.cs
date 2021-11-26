using System;
using System.Collections.Generic;
using System.Linq;

namespace LIST___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //hoe ik een array maak = vaste lengte!!
            //je start met type
            string[] array = new string[5];

            //hoe ik een list maak, variabele lengte
            //je start met keyword List
            List<string> fruit = new List<string>();

            fruit.Add("appel");
            fruit.Add("citroen");
            //elementen gaan opschuiven, niet overschrijven
            //overschrijven zou je wel doen in array
            fruit.Insert(1,"banaan");
            fruit.Insert(0, "aardbei");
            fruit.Add("appel");
            fruit.Add("appel");

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            fruit.Remove("appel");
            fruit.RemoveAt(0);

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nAlle appels verwijderen!");
            fruit.RemoveAll(w => w == "appel");            
            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\naardbei: " + fruit.Contains("aardbei"));
            Console.WriteLine("citroen: " + fruit.Contains("aardbei"));
            Console.WriteLine("banaan op plaats: " + fruit.IndexOf("banaan"));
            Console.WriteLine("appel op plaats: " + fruit.IndexOf("appel"));

            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i]);
            }

            array = fruit.ToArray();
            fruit.AddRange(array);
            fruit.Sort();
            fruit.Reverse();

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }


        }
    }
}
