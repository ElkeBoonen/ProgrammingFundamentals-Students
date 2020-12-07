using System;

namespace OO_Words_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //cherry peach lime apricot peach citron lime citron orange apple kiwi kiwi lime pineapple peach
            string woorden = "cherry peach lime apricot peach citron lime citron orange apple kiwi kiwi lime pineapple peach";
            Words words = new Words(woorden.Split(' '));

            Console.WriteLine(words.Sort());
            Console.WriteLine(words.ToString());
            Console.WriteLine(words.Occurrences());
            Console.WriteLine(words.Unique());
            Console.WriteLine(words.MostOccurrences());

        }
    }
}
