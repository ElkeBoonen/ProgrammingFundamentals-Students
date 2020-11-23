using System;
using System.Collections.Generic;

namespace Collections_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ROTATE OEFENING
            //8 19 9 10 15 5 --> 4 plaatsen
            int[] array = { 15,5,8,19,9,10 };
            int places = 4;

            int[] nieuwe_array = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int index = i + places;
                if (index >= array.Length)
                {
                    index = index - array.Length;
                } 
                nieuwe_array[index] = array[i];
                
            }

            foreach (var item in nieuwe_array)
            {
                Console.Write(item + " ");
            }
            

            List<string> lijst = new List<string>();
            lijst.Add("jan");
            lijst.Insert(0, "tuur");
            lijst.Add("mies");
            lijst.Add("bob");

            foreach (var item in lijst)
            {
                Console.Write(item +" ");
            }

            List<int> intLijst = new List<int>();
            intLijst.Add(5);
            intLijst.Add(4);
            intLijst.Add(15);
            intLijst.Add(5);

            Console.WriteLine("\n");
            foreach (var item in intLijst)
            {
                Console.Write(item + " ");
            }

            intLijst.Remove(4);    //element 4
            intLijst.RemoveAt(1);  //element op positie 1
            intLijst.Remove(5);    //element 5 verwijderen, alle vijfjes verwijderen met een loop

            Console.WriteLine("\n");
            for (int i = 0; i < intLijst.Count; i++)
            {
                Console.Write(intLijst[i] + " ");
            }
            

            List<string> toDoList = new List<string>();
            Console.WriteLine("Geef item van to do list, als alle items gegeven zijn dan stop ingeven: ");
            string antwoord = "";
            while (antwoord != "stop")
            {
                antwoord = Console.ReadLine();
                if (antwoord != "stop")
                {
                    toDoList.Add(antwoord);
                }
            }

            string[] extras = { "extra taakjes", "nog extra taakjes" };
            toDoList.AddRange(extras);
            toDoList.Sort();

            Console.WriteLine("");
            foreach (var item in toDoList)
            {
                Console.WriteLine(item + " ");
            }

            

            Dictionary<char, string> fruit = new Dictionary<char, string>();
            // 
            fruit.Add('a', "appel"); 
            fruit['b'] = "banaan";
            fruit.Add('p', "peer");
            fruit['k'] = "kiwi";
            fruit['m'] = "mango";

            foreach (var item in fruit)
            {
                Console.WriteLine(item.Key + " staat voor " + item.Value + "\t" + item );
            }

            //fruit.Add('a', "appelsien"); --> exception!!
            fruit['a'] = "appelsien";
            fruit.Remove('k');

            foreach (var item in fruit.Values)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(fruit.ContainsKey('a'));
            Console.WriteLine(fruit.ContainsValue("appelsien"));
            */

            Dictionary<DateTime, string> toDo = new Dictionary<DateTime, string>();
            Console.WriteLine("Geef items (, om te splitten) (stop om te stoppen): ");
            string antwoord = "";
            while (antwoord != "stop")
            {
                antwoord = Console.ReadLine();
                if (antwoord != "stop")
                {
                    string[] array = antwoord.Split(',');
                    toDo[Convert.ToDateTime(array[0])] = array[1].Trim();
                }
            }

           



            foreach (var item in toDo)
            {
                Console.WriteLine(item.Key + " op " + item.Value);
            }
        }
    }
}
