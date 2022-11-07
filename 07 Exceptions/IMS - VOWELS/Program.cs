using System;
using System.IO;

namespace IMS___VOWELS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een woord in: ");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine("Geef een getal in: ");
            try
            {
                int nr = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Oepsie, dit is geen getal!");
            }
            


            Console.Write("Vowels: ");
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeuio".Contains(input[i]))
                {
                    Console.Write($"{i+1} ");
                }
            }
            Console.WriteLine();

            bool flag = false;
            int position = 1;
            try
            {

                foreach (var item in File.ReadAllLines("englih.txt"))
                {
                    if (item == input)
                    {
                        flag = true;
                        break;
                    }
                    position++;
                }
                if (flag) Console.WriteLine($"Gevonden op positie {position}");
                else Console.WriteLine("Niet gevonden!");
            }
            catch
            {
                Console.WriteLine("Oepsie, er is iets verkeerd met de file!");
            }
            finally 
            {
                Console.WriteLine("Dit wordt nog altijd uitgevoerd!");
            }



        }
    }
}
