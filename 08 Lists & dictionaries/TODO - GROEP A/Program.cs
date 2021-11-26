using System;
using System.Collections.Generic;
using System.Linq;

namespace TODO___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] todo_array = new string[10];
            for (int i = 0; i < todo_array.Length; i++)
            {
                Console.Write("TAAK: ");
                todo_array[i] = Console.ReadLine();
            }

            Console.WriteLine("\nTAKEN VOOR VANDAAG");
            foreach (var item in todo_array)
            {
                Console.WriteLine($" - {item}");
            }

            List<string> todo_list = new List<string>();
            Console.Write("TAAK: ");
            string taak = Console.ReadLine();
            while (taak != "")
            {
                todo_list.Add(taak);
                Console.Write("TAAK: ");
                taak = Console.ReadLine();
            }

            Console.WriteLine("\nTAKEN VOOR VANDAAG");
            foreach (var item in todo_list)
            {
                Console.WriteLine($" - {item}");
            }*/

            Dictionary<DateTime, List<string>> todo = new Dictionary<DateTime, List<string>>();
            //invoer: 26/11/2021,taak huppeldepup
            //invoer: 1/1/2022,nieuwjaarsbrief
            Console.Write("TAAK: ");
            string taak = Console.ReadLine();
            while (taak != "")
            {
                string[] items = taak.Split(',');
                DateTime deadline = Convert.ToDateTime(items[0]);
                //check of deadline al in dictionary zit!
                if (!todo.ContainsKey(deadline))
                {   //deadline zit er nog niet in, dus er is ook nog geen lijst!!
                    //eerst lijst maken en dan item toevoegen aan lijst
                    todo[deadline] = new List<string>();
                    todo[deadline].Add(items[1]);
                }
                else
                {   //lijst van deadline bestaat al wel
                    //dus item (=taak) toevoegen aan reeds bestaande lijst!
                    todo[deadline].Add(items[1]);
                }
                Console.Write("TAAK: ");
                taak = Console.ReadLine();
            }

            DateTime[] data = todo.Keys.ToArray();
            Array.Sort(data);

            foreach (var datum in data)
            {
                if (DateTime.Now <= datum)
                {
                    Console.WriteLine($"TAKEN TEGEN {datum}");
                    foreach (var item in todo[datum])
                    {
                        Console.WriteLine($" - {item}");
                    }
                }  
            }
            

        }
    }
}
