using System;
using System.Collections.Generic;
using System.Linq;

namespace To_do_final___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TO-DO LIJST");
            Dictionary<DateTime, List<string>> todo = new Dictionary<DateTime, List<string>>();

            Console.WriteLine("Geef to-do's in als datum,taak!");
            Console.Write("TODO: ");
            string input = Console.ReadLine();

            while (input != "")
            {
                string[] items = input.Split(',');
                DateTime key = Convert.ToDateTime(items[0]);
                string taak = items[1];

                if (todo.ContainsKey(key))
                {
                    todo[key].Add(taak);
                }
                else
                {
                    todo[key] = new List<string>();
                    todo[key].Add(taak);
                }
                Console.Write("TODO: ");
                input = Console.ReadLine();
            }

            //je kan een dictionary NOOIT sorteren!!!
            //wel kan je keys & values apart sorteren
            DateTime[] keys = todo.Keys.ToArray(); //ToArray --> LinQ
            Array.Sort(keys);

            foreach (var key in keys)
            {
                Console.WriteLine("TEGEN " + key);
                foreach (var taak in todo[key])
                {
                    Console.WriteLine("\t-" + taak);
                }

            }


        }
    }
}
