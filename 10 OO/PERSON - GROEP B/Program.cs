using System;

namespace PERSON___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sam = new Person();
            Console.WriteLine(sam.Name);

            Person elke = new Person("Elke Boonen", new DateTime(1980, 4, 23));
            Console.WriteLine(elke.Name + " is " + elke.Age());
          
            //Als ik ToString() NIET overschrijf,
            //krijg ik als output: PERSON___GROEP_B.Person
            Console.WriteLine(elke);

            Person wim = new Person("Wim Kerstmis", new DateTime(1984, 12, 25));
            Console.WriteLine(wim);



        }
    }
}
