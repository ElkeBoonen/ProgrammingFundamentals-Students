using System;

namespace OO_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Person elke = new Person("Elke Boonen", new DateTime(1980,4,23));
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


        }
    }
}
