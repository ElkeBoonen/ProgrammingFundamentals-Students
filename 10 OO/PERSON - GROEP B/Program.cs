using System;
using System.Collections.Generic;

namespace PERSON___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sam = new Person();
            //Als ik ToString() NIET overschrijf,
            //krijg ik als output: PERSON___GROEP_B.Person
            Console.WriteLine(sam.Name);

            Docent elke = new Docent("Elke Boonen", new DateTime(1980, 4, 23));
            Console.WriteLine(elke.Name + " is " + elke.Age());

            /*Console.Write("Geef een naam in: ");
            string naam = Console.ReadLine();
            Console.Write("Geef een geboortedatum in: ");
            DateTime datum = Convert.ToDateTime(Console.ReadLine());
            Person persoon = new Person(naam, datum);
            Console.WriteLine(persoon);*/

            Person wim = new Person("Wim Kerstmis", new DateTime(1984, 12, 25));
            Student brent = new Student("Brent De Pauw", new DateTime(2003, 6, 3));

            List<Person> personen = new List<Person>();
            personen.Add(elke);
            personen.Add(wim);
            personen.Add(brent);
            personen.Add(sam);

            Console.WriteLine("\nRUN TIME POLYMORFISME!!");
            foreach (var item in personen)
            {
                Console.WriteLine("-" + item);
            }


        }
    }
}
