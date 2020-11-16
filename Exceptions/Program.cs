using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Geef een aantal in: ");
            string antwoord = Console.ReadLine();
            int aantal;

            Console.WriteLine("Geef een filename in: ");
            string filename = Console.ReadLine();

            if (Int32.TryParse(antwoord, out aantal))
            {
                if (File.Exists(filename))
                {
                    StreamReader file = File.OpenText(filename);
                    for (int i = 0; i < aantal; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                    file.Close();
                }
                else
                {
                    Console.WriteLine("Geen juiste filename ingegeven!");
                }
            }
            else
            {
                Console.WriteLine("Geen juist aantal ingegeven!");
            }
           

           

            try
            {
                Console.WriteLine("Geef een aantal in: ");
                int aantal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geef een filename in: ");
                string filename = Console.ReadLine();

                StreamReader file = File.OpenText(filename);
                for (int i = 0; i < aantal; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
                file.Close();
            }
            catch (FormatException) //FormatException e 
            {
                Console.WriteLine("Aantal was niet juist ingegeven");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Aantal was veel te groot");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File niet gevonden!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oepsie! Andere fout!");
                Console.WriteLine(e.Message);
            }
              


            StreamReader file = File.OpenText("english.txt");
            try
            {
                Console.WriteLine("Geef een aantal in: ");
                int aantal = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < aantal; i++)
                {
                    Console.Write(i);
                    file.ReadLine();
                }
                file.Close();
            }
            catch (FormatException) //FormatException e 
            {
                Console.WriteLine("Aantal was niet juist ingegeven");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Aantal was veel te groot");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oepsie! Andere fout!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("En op het einde...");
                file.Close();
            }
            */

            /*
             input
                Harry Potter
                output
                Harry Potter: 30 occurrences
             */

            StreamReader file = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            string text = file.ReadToEnd();
            file.Close();

            Console.WriteLine("Geef een reeks van karakters in, gescheiden door een ,");
            string[] karakters = Console.ReadLine().Split(',');

            try
            {
                Regex rx;
                MatchCollection matches;

                foreach (var item in karakters)
                {
                    rx = new Regex(item.Trim(), RegexOptions.IgnoreCase);
                    matches = rx.Matches(text);
                    Console.WriteLine(item.Trim() + ": " + matches.Count + " gevonden!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Array is kleiner!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oepsie! Andere fout!");
                Console.WriteLine(e.Message);
            }



        }
    }
}
