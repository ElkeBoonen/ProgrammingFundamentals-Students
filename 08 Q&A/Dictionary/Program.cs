using System;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //stukje uit spell it out & a in apple
            string bevat = "medical";
            foreach (var item in File.ReadAllLines("english.txt"))
            {
                if (item.Contains(bevat))
                {
                    Console.WriteLine(item);
                }
            }

            //dictionary
            string woord = "aardvark"; // Console.ReadLine()
            int counter = 1;
            //int gevonden = 0;

            foreach (var item in File.ReadAllLines("english.txt"))
            {
                if (item == woord)
                {
                    Console.WriteLine(counter);
                    return;
                    //gevonden = counter;
                }
                counter++;
            }
            Console.WriteLine("not found!");

            /*if (gevonden == 0)
            {
                Console.WriteLine("not found!");
            }
            else
            {
                Console.WriteLine(gevonden);
            }*/

        }
    }
}
