using System;

namespace DSPs___Word_nest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            //PERFECT WORDNEST
            string wordnest = "cocodccococodededeodeede"; //Console.ReadLine();
            int count = 0;
            while (wordnest.Length != word.Length) //(wordnest.Length != 0)
            {
                wordnest = wordnest.Replace(word, "");
                Console.WriteLine(wordnest);
                count++;
            }
            Console.WriteLine(count);              //count-1


            //NOT SO PERFECT WORDNEST
            wordnest = "cocodccococodededeodeoede"; //Console.ReadLine();
            count = 0;
            while (wordnest.Contains(word)) //(wordnest.Length != 0)
            {
                wordnest = wordnest.Replace(word, "");
                Console.WriteLine(wordnest);
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
