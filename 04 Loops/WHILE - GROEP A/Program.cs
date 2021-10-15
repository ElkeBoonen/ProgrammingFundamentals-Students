using System;

namespace WHILE___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Geef Y/y in om verder te gaan: ");
            string verder = Console.ReadLine();

            while (verder == "Y" || verder == "y") //verder.ToLower()=="y" //verder.ToUpper()=="Y"
            {
                Console.Write("Geef Y/y in om verder te gaan: ");
                verder = Console.ReadLine();
                //HEEL BELANGRIJK!!!! Pas de variabele van de voorwaarde aan in de lus!!!!!
            }

            */

            Console.Write("Geef een getal in: ");
            double getal = Convert.ToDouble(Console.ReadLine());

            if (getal <= 1) {
                Console.WriteLine("Getal is kleiner of gelijk aan 1, dus gaat niet lukken!");
                return; //stop!
            }
            

            double result = getal; //we starten ipv 1 (getal^0) op getal^1

            Console.WriteLine("\n\nWHILE - EERST PRINT DAN BEREKENING");
            while (result <= 10000)
            {
                Console.Write(result + " ");
                result *= getal; //result = result * getal
            }

            result = getal;
            Console.WriteLine("\n\nWHILE - EERST BEREKENING DAN PRINT");
            while (result <= 10000)
            {
                result *= getal; //result = result * getal
                Console.Write(result + " ");
            }

            result = getal;
            Console.WriteLine("\n\nDO WHILE - EERST PRINT DAN BEREKENING");
            do
            {
                Console.Write(result + " ");
                result *= getal; //result = result * getal
            }
            while (result <= 10000) ;


            result = getal;
            Console.WriteLine("\n\nDO WHILE - EERST BEREKENING DAN PRINT");
            do
            {
                result *= getal; //result = result * getal
                Console.Write(result + " ");
            } 
            while (result <= 10000);

            Console.WriteLine("\n\nMAALTAFELS");

            int i = 0;
            while (i <= 10)
            {
                //volgorde van statements = de sequentue is super belangrijk!!!
                result = i * getal;
                Console.WriteLine($"{i} * {getal} = {result}");
                i++;
            }

        }
    }
}
