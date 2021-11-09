using System;
using System.IO;

namespace EXCEPTIONS___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {

            //FOUTAFHANDELING MET IF- STRUCTUREN
            /*
            Console.Write("Geef een aantal lijnen in: ");
            string antwoord = Console.ReadLine();
            int nr;
            if (!Int32.TryParse(antwoord, out nr))
            {
                Console.WriteLine("Verkeerde input! Aantal lijnen is nu 10!");
                nr = 10;
            }
            
            Console.Write("Geef een filenaam in: ");
            string filenaam = Console.ReadLine();

            if (!File.Exists(filenaam))
            {
                Console.WriteLine("Verkeerde input! File is nu english.txt!");
                filenaam = "english.txt";
            }

            StreamReader stream = File.OpenText(filenaam);
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine(stream.ReadLine());
            }
            stream.Close();
            */
            try
            {
                Console.Write("Geef een aantal lijnen in: ");
                int nr = Convert.ToInt32(Console.ReadLine()); //kan exceptie geven
                Console.Write("Geef een filenaam in: ");
                string filenaam = Console.ReadLine();

                StreamReader stream = File.OpenText(filenaam); //kan exceptie geven
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(stream.ReadLine());
                }
                stream.Close();
            }
            //excepties van specifiek naar algemeen!!!
            catch (FileNotFoundException)
            {
                Console.WriteLine("File bestaat niet!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Aantal lijnen was verkeerd ingegeven!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Er liep iets mis: " + e.Message); ;
                //Console.WriteLine(e.StackTrace);
            }
            finally {
                Console.WriteLine("einde code!");
            }
            

        }
    }
}
