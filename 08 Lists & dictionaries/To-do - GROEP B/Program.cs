using System;
using System.Collections.Generic;

namespace To_do___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //to-do lijstje
            //-diereneten gaan kopen
            //-lesgeven
            //-oefeningen plagiaat herbekijken
            //-nadenken wat we gaan eten
            //-lessen voorbereiden voor donderdag
            //-e-boeken met mijn zus delen

            //1e manier: met split werken en alle todo's ineens ingeven
            Console.WriteLine("Geef alle to-do's gescheiden door komma");
            string[] todo1 = Console.ReadLine().Split(',');
            foreach (var item in todo1)
            {
                Console.WriteLine("-" + item);
            }

            Console.WriteLine("\n\n");
            //2e manier: lengte ingeven en vullen
            string[] todo2 = new string[10];
            for (int i = 0; i < todo2.Length; i++)
            {
                Console.Write($"Geef todo {i+1} in: ");
                todo2[i] = Console.ReadLine();
            }
            foreach (var item in todo2)
            {
                Console.WriteLine("-" + item);
            }

            //3e manier: werken met lijsten
            
            List<string> todolist = new List<string>();

            Console.Write("Geef todo in: ");
            string todo = Console.ReadLine();
            while (todo != "")
            {
                todolist.Add(todo);
                Console.Write("Geef todo in: ");
                todo = Console.ReadLine();
            }

            todolist.Sort();
            todolist.Reverse();

            Console.WriteLine("\nMijn to-do lijst: ");
            foreach (var item in todolist)
            {
                Console.WriteLine("-" + item);
            }

            //4e manier: werken met dictionary 
            //todo & deadline
            Dictionary<string, DateTime> tododic = new Dictionary<string, DateTime>();
            Console.WriteLine("Geef todo als taak,datum");
            todo = Console.ReadLine();
            //eten maken,23/11/2021
            while (todo != "")
            {
                string[] items = todo.Split(',');
                //eten maken,23/11/2021 --> split op ,
                //item[0] = eten maken
                //item[1] = 23/11/2021 --> convert to datetime
                tododic.Add(items[0],Convert.ToDateTime(items[1]));
                Console.Write("TODO: ");
                todo = Console.ReadLine();
            }

            Console.WriteLine("\nMijn to-do lijst: ");
            foreach (var item in tododic)
            {
                Console.WriteLine("-" + item);
            }
            

        }
    }
}
