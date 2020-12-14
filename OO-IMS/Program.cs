using System;
using System.Collections.Generic;

namespace OO_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher elke = new Teacher("Elke Boonen", new DateTime(1980,4,23));
            Person jef = new Person("Jef Boonen", new DateTime(1980, 4, 23));
            Person john = new Person();
            elke.Print();

            elke.Name = "Boonen Elke";

            elke.Print();
            john.Print();

            Console.WriteLine(elke.Name + " is " + elke.Age() + " jaar oud! --> gewoon in Main");

            Console.WriteLine(elke.ToString());
            Console.WriteLine(jef.ToString());
            Console.WriteLine(john.ToString());

            Teacher an = new Teacher("An Dinges", new DateTime(1975,1,1));
            Student jan = new Student("Jan Dinges", new DateTime(2000, 1, 1));

            Console.WriteLine(an.ToString());
            Console.WriteLine(jan.ToString());

            List<Person> persoontjes = new List<Person>();

            persoontjes.Add(elke);
            persoontjes.Add(an);
            persoontjes.Add(john);
            persoontjes.Add(jef);
            persoontjes.Add(jan);

            Course prog = new Course("Programming", elke, "Online", 3, new Time(13,45), WeekDays.Monday);
            Course db = new Course("Databases", an, "Online", 3, new Time(), WeekDays.Monday);
            Course web = new Course("Web", an, "Online", 3, new Time(9,00), WeekDays.Friday);

            List<Course> courses = new List<Course>();
            courses.Add(prog);
            courses.Add(db);
            courses.Add(web);

            jan.Courses = courses;

            Console.WriteLine("\n\nMijn lijst van personen");
            foreach (var item in persoontjes)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
