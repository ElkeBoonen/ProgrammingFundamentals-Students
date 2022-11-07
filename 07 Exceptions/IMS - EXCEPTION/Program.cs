using System;
using System.IO;

namespace IMS___EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geef een int in: ");
                int nr = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geef een filename in: ");
                string filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);
                Console.WriteLine(lines[nr]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Oeps, int was niet in correcte formaat");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Oeps, dit is te groot of te klein voor een int");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Oeps, file wordt niet gevonden");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Oeps, index van dit woord bestaat niet");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oeps: " + ex.Message);
            }

            
        }
    }
}
