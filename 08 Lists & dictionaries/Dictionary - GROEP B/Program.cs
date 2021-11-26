using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dic1 = new Dictionary<char, string>();
            dic1.Add('a', "appel");
            dic1['c'] = "citroen";
            dic1['a'] = "aardbei";
            dic1['A'] = "aardbei";
            //dic1.Add('a', "avocado"); als key reeds bestaat : Exception!

            Console.WriteLine("aantal elementen: " + dic1.Count);
            Console.WriteLine("Bevat key 'a': " + dic1.ContainsKey('a'));
            Console.WriteLine("Bevat value appel: " + dic1.ContainsValue("appel"));
            
            //dictionary overlopen --> resultaat tussen [,]
            foreach (var item in dic1)
            {
                Console.WriteLine(item);
            }

            //keys uit dictionary overlopen
            Console.Write("KEYS: ");
            foreach (var item in dic1.Keys)
            {
                Console.Write(item + " ");
            }

            //values uit dictionary overlopen
            Console.Write("\nVALUES: ");
            foreach (var item in dic1.Values)
            {
                Console.Write(item + " ");
            }

            //element verwijderen uit dictionary
            Console.WriteLine("\nVerwijder key 'c' ");
            dic1.Remove('c');
            //dictionary overlopen (var pair = <key, value>)
            foreach (var pair in dic1) 
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            //dictionary overlopen met for-loop!
            for (int i = 0; i < dic1.Count; i++)
            {
                Console.WriteLine(dic1.ElementAt(i)); //ElementAt in LinQ
            }

            Console.WriteLine("\n");


            Dictionary<int, char> dic2 = new Dictionary<int, char>();
            dic2.Add(12, 'b');
            dic2.Add(11, 'b');
            dic2[10] = 'b';
            dic2[20] = 'b';
            dic2[0] = 'b';
            dic2[1] = 'B';
            foreach (var item in dic2)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //ik wil al mijn b's verwijderen, hoe?
            Console.WriteLine("Verwijder alle b's");
            foreach (var item in dic2)
            {
                if (item.Value == 'b') dic2.Remove(item.Key);
            }
            foreach (var item in dic2)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
