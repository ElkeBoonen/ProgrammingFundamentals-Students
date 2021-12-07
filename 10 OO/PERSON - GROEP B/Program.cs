﻿using System;
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
            Docent collin = new Docent("Collin Van der Vorst", new DateTime(1991, 5, 1));

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

            Course programming = new Course("Programming", elke, 4, new Time(8,30), Weekday.Tuesday);
            Course web = new Course("Web", collin, 3, new Time(9, 30), Weekday.Thursday);

            Console.WriteLine("\nCURSUSSEN TOEVOEGEN AAN STUDENT");
            brent.Courses.Add(programming);
            brent.Courses.Add(web);
            Console.WriteLine(brent);


        }
    }
}
