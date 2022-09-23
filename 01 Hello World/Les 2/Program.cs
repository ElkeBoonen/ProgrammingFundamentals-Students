namespace Les_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Elke";
            Console.WriteLine(name);
            Console.WriteLine("name");
            name = "Tuur";
            Console.WriteLine(name);

            string color = "green";
            color = "blue";
            Console.WriteLine(color);

            // color = 67; je kan geen getal in een string steken!
            // tenzij je van je getal een string maakt

            string number = "45"; //dit slaat natuurlijk nergens op ;)

            //alles tussen " " is ALTIJD een STRING

            /*iets inlezen van de gebruiker
              iets inlezen doen we altijd met ReadLine
              en wat we inlezen bewaren we in een variabele! */

            Console.WriteLine("Wat is je naam?");
            name = Console.ReadLine();
            
            Console.WriteLine("Wat is je lievelingskleur?");
            color = Console.ReadLine();

            Console.WriteLine("Wat is je lievelingsgetal?");
            number = Console.ReadLine();

            Console.WriteLine("Hallo " + name);
            Console.WriteLine($"Jouw lievelingskleur is {color}");
            Console.WriteLine(number);


        }
    }
}