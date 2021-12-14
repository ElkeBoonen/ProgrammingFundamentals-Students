using System;
using System.Collections.Generic;

namespace Bankaccount___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OPEN Fortis 1000
            STORTING Fortis 10
            OPEN KBC 2000
            AFHALING Fortis 100
            PRINT Fortis
            PRINT KBC*/

            List<Bankrekening> rekeningen = new List<Bankrekening>();

            while (true)
            {

                Console.WriteLine("Wat wilt u doen?\n" +
                    "Druk 1 om rekening te openen\n" +
                    "Druk 2 om geld te storten\n" +
                    "Druk 3 om geld af te halen\n" +
                    "Druk 4 om transacties te tonen");
                string antwoord = Console.ReadLine();

                string[] array; //aanmaken zodat ik alles kan gebruiken in mijn switch case
                switch (antwoord)
                {
                    case "1":
                        Console.WriteLine("Geef naam & saldo in (gescheiden met spatie):");
                        array = Console.ReadLine().Split(' ');
                        rekeningen.Add(new Bankrekening(array[0], Convert.ToDouble(array[1])));
                        break;
                    case "2":
                        Console.WriteLine("Geef naam & geld in (gescheiden met spatie):");
                        array = Console.ReadLine().Split(' ');
                        foreach (var item in rekeningen)
                        {
                            if (item.Eigenaar == array[0])
                            {
                                item.Storten(Convert.ToDouble(array[1]));
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Geef naam & geld in (gescheiden met spatie):");
                        array = Console.ReadLine().Split(' ');
                        double geld = Convert.ToDouble(array[1]);
                        try
                        {
                            rekeningen.Find(element => element.Eigenaar == array[0]).Afhalen(geld);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Geef naam in:");
                        string naam = Console.ReadLine();
                        Console.WriteLine(rekeningen.Find(element => element.Eigenaar == naam));
                        break;
                    default: return;
                }
            }



        }
    }
}
