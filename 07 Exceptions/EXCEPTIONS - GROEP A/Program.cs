using System;
using System.IO;

namespace EXCEPTIONS___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXCEPTION HANDLING MET IF-STRUCTUREN!!!
            /*Console.Write("Geef aantal lijnen in: ");
            string antwoord = Console.ReadLine();
            int aantal;
            if (Int32.TryParse(antwoord, out aantal) == false)
            { //het is geen success, oepsie!
                Console.WriteLine("Verkeerd getal ingegeven!");
                return;
            }

            Console.Write("Geef een filenaam in: ");
            string filenaam = Console.ReadLine(); // kan fout lopen
            if (!File.Exists(filenaam)) //zelfde als File.Exists(filenaam)==false
            {
                Console.WriteLine("File bestaat niet!");
                return;
            }
            StreamReader stream = File.OpenText(filenaam);
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine(stream.ReadLine());
            }
            stream.Close();
            */

            try
            {
                Console.Write("Geef aantal lijnen in: ");
                int aantal = Convert.ToInt32(Console.ReadLine()); //kan fout lopen
                Console.Write("Geef een filenaam in: ");
                string filenaam = Console.ReadLine(); // kan fout lopen

                StreamReader stream = File.OpenText(filenaam);
                for (int i = 0; i < aantal; i++)
                {
                    Console.WriteLine(stream.ReadLine());
                }
                stream.Close();
            }
            catch (FormatException)
            {
                Console.WriteLine("U gaf een verkeerd getal in!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Deze file bestaat niet!");
            }
            catch (Exception e)
            {
                Console.WriteLine("oepsie! Er liep iets verkeerd!");
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("The end!");
            }
            
           
        }
    }
}
