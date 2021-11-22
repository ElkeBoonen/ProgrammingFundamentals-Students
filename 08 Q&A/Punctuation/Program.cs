using System;

namespace Punctuation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Wow?!! But why??!!?? Who knows..."; //Console.ReadLine()

            char c = ' ';
            foreach (var item in input)
            {
                //if ("!?,.\"';:".Contains(item)) 
                if (Char.IsPunctuation(item))
                {
                    if (c != item)
                    {
                        Console.Write(item);
                        c = item;
                    }
                }
                else
                {
                    Console.Write(item);
                }
            }
            
        }
    }
}
