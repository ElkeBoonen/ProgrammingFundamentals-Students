using System;

namespace IMS___Wordnest
{
    internal class Program
    {
        //cocodccococodededeodeede

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string wordnest = Console.ReadLine();

            int count = 0;
            while (wordnest != word) //of wordnest.Length!= 0, maar let op count-1
            {
                Console.WriteLine(wordnest);
                wordnest = wordnest.Replace(word, "");
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
