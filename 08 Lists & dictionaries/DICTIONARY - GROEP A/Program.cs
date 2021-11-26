using System;
using System.Collections.Generic;
using System.Linq;

namespace DICTIONARY___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> fruit = new Dictionary<char, string>();

            fruit.Add('a', "appel");
            fruit.Add('k', "kiwi");
            //fruit.Add('a', "aardbei"); --> duplicate key, geeft error!
            fruit['a'] = "aardbei";
            fruit['c'] = "citroen";
            fruit['A'] = "appel";
            fruit['@'] = "appel";

            Console.WriteLine("FRUIT OVERLOPEN");
            foreach (var item in fruit) //uit item key & value halen
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("FRUIT VALUES");
            foreach (var item in fruit.Values) //enkel values
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("FRUIT KEYS");
            foreach (var item in fruit.Keys) //enkel keys
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("REMOVE a");
            fruit.Remove('a');
            foreach (var item in fruit) //item als key/value afdrukken
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("REMOVE appels");
            //alle appels eruit halen
            foreach (var item in fruit)
            {
                if (item.Value == "appel")
                {
                    fruit.Remove(item.Key);
                }
            }
            foreach (var item in fruit) //item als key/value afdrukken
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("appel en banaan toevoegen");
            fruit['a'] = "appel";
            fruit['b'] = "banaan";
            foreach (var item in fruit) //item als key/value afdrukken
            {
                Console.WriteLine(item);
            }

            char[] keys = fruit.Keys.ToArray(); ;
            Array.Sort(keys);
            foreach (var key in keys)
            {
                Console.WriteLine(key + ": " + fruit[key]);
            }

            Console.WriteLine("value appel? " + fruit.ContainsValue("appel"));
            Console.WriteLine("key p? " + fruit.ContainsKey('p'));

            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine($"{i} --> {fruit.ElementAt(i)}");
            }
        }
    }
}
