using System;
using System.IO;

namespace DSPS___EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NEW WAY --> WORKING WITH EXCEPTION HANDLING
            try
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                Console.Write("Enter a linenumber: ");
                int linenr = Convert.ToInt32(Console.ReadLine());
                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[linenr]);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File was not found!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Linenumber was not valid for this file!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Linenumber was not a correct number!");
            }
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Linenumber was too big!");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
          




            //OLD WAY OF DOING THINGS
            /*Console.Write("Enter filename: ");
            string file = Console.ReadLine();

            Console.Write("Enter a linenumber: ");
            int linenr;
            if (!Int32.TryParse(Console.ReadLine(), out linenr))
            {
                Console.WriteLine("Not a valid linenumber! We stop!");
                return;
            }

            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length)
                {
                    Console.WriteLine("Linenumber too big! We stop!");
                    return;
                }
                Console.WriteLine(text[linenr]);
            }
            else
            {
                Console.WriteLine("Not a valid file! We stop!");
                return;
            }
            */
        }
    }
}
