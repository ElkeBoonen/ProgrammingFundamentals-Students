using System;
using System.Collections.Generic;

namespace PERSON___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher elke = new Teacher("Elke Boonen", new DateTime(1980, 4, 23));
            Person alex = new Person();

            //Console.Write("Geef naam in: ");
            string naam = "Jan Janssens";//Console.ReadLine();
            //Console.Write("Geef geboortedatum in: ");
            DateTime datum = Convert.ToDateTime("12/12/2000"); //Console.ReadLine()
            Person persoon = new Person(naam, datum);

            List<Person> personen = new List<Person>();
            personen.Add(elke);
            personen.Add(alex);
            personen.Add(persoon);


            Teacher collin = new Teacher("Collin", new DateTime(1991, 4, 16));

            Course programming = new Course("Programming", elke, 4, new Time(8, 30), Weekday.Friday);
            Course web = new Course("Web", collin, 3, new Time(13, 45), Weekday.Wednesday);
            List<Course> courses = new List<Course>();
            courses.Add(programming);
            courses.Add(web);

            Console.WriteLine(programming);
            Console.WriteLine(web);

            Student jarne = new Student("Jarne Schoolmeesters", 
                new DateTime(1999, 5, 17), "Thomas More", courses);
            
            personen.Add(jarne);

            alex.Name = "Alexia Van Mechelen";

            Console.WriteLine("\nPERSONEN IN MIJN LIJST");
            foreach (var item in personen)
            {
                Console.WriteLine(item);
                if (item.GetType() == typeof(Student))
                {
                    Console.WriteLine(" --> leeftijd student " + item.Age());
                }
            }

            

            



        }
    }
}
