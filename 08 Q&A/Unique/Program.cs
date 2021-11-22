using System;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = "appel appel appel appel appel peer banaan".Split(' '); 
                              //Console.ReadLine();
            //bubble sort
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length - 1; j++)
                {
                    if (words[j].CompareTo(words[j + 1]) > 0) //String.Compare(array[j], array[j+1])
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            string woord = "";
            for (int i = 0; i < words.Length-1; i++)
            {
                woord = words[i + 1];
                if (words[i] != words[i + 1])
                {
                    Console.WriteLine(words[i] + " ");
                }
            }
            Console.WriteLine(woord);

            woord = "";
            foreach (var item in words)
            {
                if (woord != item)
                {
                    Console.Write(item + " ");
                    woord = item;
                }
            }

            
        }
    }
}
