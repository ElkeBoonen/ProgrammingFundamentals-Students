using System;
using System.Collections.Generic;
using System.Linq;

namespace List___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Elementen toevoegen");

            list.Add(10);
            list.Add(15);
            list.Add(23);
            list.Insert(0, 4);
            list.Insert(1, 8);
            list.Add(10);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.RemoveAt(1);
            list.Remove(10); //eerste 10 wordt verwijderd!
            Console.WriteLine("\nElementen verwijderen");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nBevat 10? " + list.Contains(10));
            Console.WriteLine("Bevat 8? " + list.Contains(8));
            Console.WriteLine("Bevat " + list.Count + " elementen");
            Console.WriteLine("Index van 23: " + list.IndexOf(23));
            Console.WriteLine("Index van 8: " + list.IndexOf(8));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List<double> listdouble = list.ConvertAll(Convert.ToDouble);
            listdouble.Add(5.6);
            listdouble.AddRange(new double[]{ 7.1, 7.8, 1 });

            foreach (var item in listdouble)
            {
                Console.Write(item + " ");
            }

            string[] array = { "jan", "piet", "joris", "korneel" };
            List<string> liststring = array.ToList();
            liststring.Add("marie");

        }
    }
}
