using System;

namespace Alcohol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw geboortejaar in: ");
            string answer = Console.ReadLine();

            int year;
            bool converted = Int32.TryParse(answer, out year);

            int age;

            if (converted) //converted==true
            {
                age = DateTime.Now.Year - year;
                if (age < 16)
                {
                    Console.WriteLine("Jammer, je mag niets!");
                }
                else if (age >= 16 && age < 18)
                {
                    Console.WriteLine("Je mag al een biertje of een wijntje drinken!");
                }
                else
                {
                    Console.WriteLine("Je mag loos gaan! Hoera! ;)");
                }
            }
            else
            {
                Console.WriteLine("Verkeerde ingave. Duidelijk niet bekwaam genoeg om alcohol te drinken!");
            }

            ///////////////////////////
            ///////andere versie!/////
            //////////////////////////
            if (!converted)
            {
                Console.WriteLine("Verkeerde ingave. Duidelijk niet bekwaam genoeg om alcohol te drinken!");
                return; //return stopt een methode! dus programma stopt hier!
                        //break stopt een structuur
            }

            age = DateTime.Now.Year - year;
            if (age < 16)
            {
                Console.WriteLine("Jammer, je mag niets!");
            }
            else if (age >= 16 && age < 18)
            {
                Console.WriteLine("Je mag al een biertje of een wijntje drinken!");
            }
            else
            {
                Console.WriteLine("Je mag loos gaan! Hoera! ;)");
            }

        }
    }
}
