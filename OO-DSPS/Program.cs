using System;
using System.Collections.Generic;

namespace OO_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            Person elke = new Person("Elke", new DateTime(1980, 4, 23));

            Console.WriteLine(elke.Name);
            elke.Name = "Elke Boonen";
            Console.WriteLine(elke.Name + " " + elke.Age());

            Console.WriteLine(elke.ToString()); ;

            elke.Print();

            Student bob = new Student("Bob", new DateTime(2000,5,2));
            Teacher christophe = new Teacher("Christophe", new DateTime(1980, 1, 14));

            List<Person> people = new List<Person>();
            people.Add(bob);
            people.Add(elke);
            people.Add(christophe);
            people.Add(john);

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}
