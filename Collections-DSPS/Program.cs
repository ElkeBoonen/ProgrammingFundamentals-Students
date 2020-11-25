using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             15 5 8 19 9 10 --> array
             4 --> rotate it 4 places
             8 19 9 10 15 5
            

            int[] array = { 15, 5, 8, 19, 9, 10 };
            int places = 4;

            int[] new_array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int new_index = i + places;
                if (new_index >= array.Length) // 6 7 8 9
                {
                    new_index = new_index - 6;
                }
                new_array[new_index] = array[i];
            }

            foreach (var item in new_array)
            {
                Console.Write(item + " " );
            }


            List<string> list = new List<string>();
            List<int> intList = new List<int>();

            list.Add("jan");
            list.Insert(0, "tuur");
            list.Add("mies");
            list.Add("bob");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            intList.Add(5);
            int[] nrs = { 6, 5, 7, 8, 9, 5 };
            intList.AddRange(nrs);
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //5 5 6 7 8 9 5
            Console.WriteLine();
            intList.RemoveAt(5); //removing at index 5
            intList.Remove(5); //remove item with value 5
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //intList.RemoveAll(5);
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == 5)
                {
                    intList.Remove(intList[i]);
                } 
            }
            Console.WriteLine();
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            

            Console.WriteLine("Enter todo-items ('stop' to stop):");
            List<string> todoList = new List<string>();
            string answer = Console.ReadLine();
            while (answer != "stop")
            {
                todoList.Add(answer);
                answer = Console.ReadLine();
            }

            Console.WriteLine("Your To Do list is:");
            foreach (string todoElement in todoList)
            {
                Console.WriteLine(todoElement);
            }

            //todoList.ToArray(); --> transform to array
            //int[] array = { 1, 2, 3, 4 };
            //array.ToList();  --> transform to list (using system.Linq)
            */

            Dictionary<char, string> fruit = new Dictionary<char, string>();
            //Dictionary<int, double> dic = new Dictionary<int, double>();
            //Dictionary<int, string> dic1 = new Dictionary<int, string>();

            fruit.Add('a', "apple");
            fruit['b'] = "banana";
            fruit.Add('o', "orange");
            //fruit.Add('a', "avocado"); //ADD will give an exception if the key exists!
            fruit['a'] = "avocado";     //will overwrite apple

            foreach (var item in fruit)
            {
                Console.WriteLine(item + "\t" + item.Key + "-->" + item.Value);
            }

            Console.WriteLine(fruit.ContainsKey('a'));
            Console.WriteLine(fruit.ContainsValue("apple"));

            fruit.Remove('a');

            foreach (var item in fruit)
            {
                Console.WriteLine(item + "\t" + item.Key + "-->" + item.Value);
            }

            if (fruit.ContainsValue("orange"))
            {
                char key=' ';
                foreach (var item in fruit)
                {
                    if (item.Value == "orange") key = item.Key;
                }
                fruit.Remove(key);
            
            }

            foreach (var item in fruit.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in fruit.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
