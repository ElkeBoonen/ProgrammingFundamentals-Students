using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace IMS___Yellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://learn.microsoft.com/en-us/dotnet/api/system.drawing.colortranslator.fromole?view=net-6.0#system-drawing-colortranslator-fromole(system-int32
            string hex = Console.ReadLine();
            int color = Convert.ToInt32(hex,16);

            // Translate oleColor to a GDI+ Color structure.
            Color myColor = ColorTranslator.FromOle(color);

            if (myColor.IsKnownColor)
            {
                string text = File.ReadAllText("ColdPlay.txt");

                Regex regex = new Regex(@"\b" + myColor.Name + @"\b", RegexOptions.IgnoreCase);

                MatchCollection collection = regex.Matches(text);

                if (collection.Count == 0) Console.WriteLine($"It wasn't {myColor.Name}");
                else Console.WriteLine($"{myColor.Name}: {collection.Count} matches");
            }
            else Console.WriteLine($"Colorless");


        }
    }
}
