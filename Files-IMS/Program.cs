using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //verschillende manieren om files aan te maken met en zonder pad
            string filename = "file.txt"; //file komt in output directory
            filename = @"C:\file.txt";
            filename = Path.Combine(@"C:\", "file.txt");
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //speciale folders raadplegen
            filename = Path.Combine(folder, "file.txt");

            Console.WriteLine("CREATE TEXT");
            StreamWriter output = File.CreateText(filename);
            output.WriteLine("1");
            output.WriteLine("2");
            output.WriteLine("3");
            output.Close();

            if (File.Exists(filename))
            {
                Console.WriteLine("APPEND TEXT");
                output = File.AppendText(filename);
                output.WriteLine("4");
                output.WriteLine("5");
                output.WriteLine("6");
                output.Close();
            }
            Console.WriteLine("DELETE TEXT");
            File.Delete(filename);
            
            //read to end, lees alles ineens in
            Console.WriteLine("\n\nREAD TO END");
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            Console.WriteLine(text);
            input.Close();

            //lees lijn per lijn in
            Console.WriteLine("\n\nREAD LINE BY LINE");
            input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();
            while (line != null)
            {
                Console.WriteLine("LINE: " + line);
                line = input.ReadLine(); //volgende lijn inlezen!!!!
            }
            input.Close();

            //lees karakter per karakter in
            Console.WriteLine("\n\nREAD CHAR BY CHAR");
            input = File.OpenText("Rapunzel.txt");
            char c = (char)input.Read();
            while (!input.EndOfStream)
            {
                Console.Write(c + " ");
                c = (char)input.Read(); //volgende karakter inlezen!!!!
            }
            input.Close();

            //we gebruiken text-variabele die gevuld werd bij
            //read to end (eerste keer inlezen) --> Console.WriteLine(text);
            //lees op een andere manier karakter per karakter in
            Console.WriteLine("\n\nREAD CHAR BY CHAR ---- FOR LOOP");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text.ElementAt(i) + " ");
            }

            //de eerste keer een for-loop, whoop whoop
            Console.WriteLine("\n\nREAD CHAR BY CHAR ---- FOREACH LOOP");
            foreach (char karakter in text)
            {
                Console.Write(karakter + " ");
            }

            //tekst onderzoek met string class
            Console.WriteLine("\n\nSTRING CLASS");
            Console.WriteLine("Lengte: " + text.Length);
            Console.WriteLine("Eerste 10: " + text.Substring(0,10));
            Console.WriteLine("Laatste 10: " + text.Substring(text.Length-10, 10));
            Console.WriteLine("Rapunzel in tekst? " + text.Contains("Rapunzel"));
            Console.WriteLine("Eerste keer Rapunzel: " + text.IndexOf("Rapunzel"));
            text = text.ToLower();
            //rapunzel met hoofdletter wordt niet meer gevonden!
            Console.WriteLine("Eerste keer Rapunzel: " + text.IndexOf("Rapunzel"));
            //alles in kleine letters!!
            Console.WriteLine("Eerste keer rapunzel: " + text.IndexOf("rapunzel"));
            Console.WriteLine("Eerste keer rapunzel: " + text.LastIndexOf("rapunzel"));

            //aantal keer Rapunzel opvragen
            string woord = "";
            int teller = 0;
            foreach (char karakter in text)
            {
                //switch is een optie
                if ((karakter >= 97) && (karakter <= 122)) //ik ben een woord aan het maken!
                {
                    woord += karakter; //woord = woord + c
                }
                else
                {
                    if (woord == "rapunzel") teller++;
                    woord = "";
                }
            }
            Console.WriteLine("Aantal keer rapunzel: " + teller);

            //aantal keer rapunzel opvragen met regex
            Regex rx = new Regex(@"RAPUNZEL", RegexOptions.IgnoreCase); //maakt niet uit lower of uppercase
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine("Aantal keer rapunzel: " + matches.Count);

            //woorden met 10 karakters uitprinten
            woord = "";
            string abc = "azertyuiopqsdfghjklmwxcvbn";
            foreach (char karakter in text)
            {
                if (abc.Contains(karakter))
                {
                    woord += karakter; //woord = woord + c
                }
                else
                {
                    if (woord.Length == 10) Console.WriteLine(woord);
                    woord = "";
                }
            }

            //woorden met 10 karakters uitprinten adhv regex
            rx = new Regex(@"\b[a-zA-Z]{10}\b"); 
            matches = rx.Matches(text);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }

            //aantal woorden tellen in een tekst - manier 1
            rx = new Regex(@"\S+");
            matches = rx.Matches(text);
            Console.WriteLine("Aantal woorden: " + matches.Count);

            //aantal woorden tellen in een tekst - manier 2
            rx = new Regex(@"\b[a-z]+\b");
            matches = rx.Matches(text);
            Console.WriteLine("Aantal woorden: " + matches.Count);

            //aantal woorden tellen in een tekst - manier 3
            rx = new Regex(@" ");
            matches = rx.Matches(text);
            Console.WriteLine("Aantal woorden: " + matches.Count);

            //aantal woorden tellen in een tekst - manier 4
            rx = new Regex(@"\w+");
            matches = rx.Matches(text);
            Console.WriteLine("Aantal woorden: " + matches.Count);

        }
    }
}
