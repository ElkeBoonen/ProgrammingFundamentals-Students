using System;

namespace WHILE___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wil je verder gaan? (ja): ");
            string answer = Console.ReadLine();

            while (answer.ToLower() == "ja")
            {
                Console.Write("Wil je verder gaan? (ja): ");
                answer = Console.ReadLine(); //de variabele van de conditie MOET aangepast worden in lus zelf!!!
            }

            Console.Write("Een getal voor de exponentiele reeks: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nWHILE - EERST PRINT");


            int macht = getal;
            while (macht < Int16.MaxValue)
            {
                Console.Write(macht + " ");
                macht = macht * getal; //macht *= getal;
            }

            Console.WriteLine("\nWHILE - PRINT ERNA");
            macht = getal;
            while (macht < Int16.MaxValue)
            {
                macht = macht * getal; //macht *= getal;
                Console.Write(macht + " ");
            }

            Console.WriteLine("\nDO WHILE - EERST PRINT");
            macht = getal;
            do
            {
                Console.Write(macht + " ");
                macht = macht * getal; //macht *= getal;
            } while (macht < Int16.MaxValue);


            Console.WriteLine("\nDO WHILE - PRINT ERNA");
            macht = getal;
            do
            {
                macht = macht * getal; //macht *= getal;
                Console.Write(macht + " ");
            } while (macht < Int16.MaxValue);

            Console.WriteLine("\n");

            Console.WriteLine("max value " + Int16.MaxValue);

        }
    }
}
