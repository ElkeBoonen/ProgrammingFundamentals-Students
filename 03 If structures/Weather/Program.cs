using System;

namespace Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  RAIN: YES/FALSE
             *  TEMP: INT
             *  
             *  - Temp < 0 then Freezing weather --> snowing
                - Temp 0 - 10 then Very Cold weather --> it's too cold to rain
                - Temp 10 - 20 then Cold weather --> autumn rain 
                - Temp 20 - 30 then Normal in Temp --> showers
                - Temp 30 - 40 then Its Hot --> showers
                - Temp >= 40 then Its Very Hot --> tropical storm */

            Console.Write("Enter temperature: ");
            string answer = Console.ReadLine();
            Console.Write("Enter rain (yes/no): ");
            string rain = Console.ReadLine();

            int temp;
            if (!Int32.TryParse(answer, out temp))
            {
                Console.WriteLine("crazy input");
                return;
            }

            //Temp < 0 then Freezing weather-- > snowing
            if (temp <= 0)
            {
                if (rain == "yes")
                {
                    Console.WriteLine("Snowtime!");
                }
                else
                {
                    Console.WriteLine("Freezing weather");
                }
            }
            //Temp 0 - 10 then Very Cold weather --> it's too cold to rain
            else if (temp > 0 && temp < 10)
            {
                if (rain == "yes")
                {
                    Console.WriteLine("Stupid weather ;)");
                }
                else
                {
                    Console.WriteLine("Very Cold weather");
                }
            }
            //Temp 10 - 20 then Normal weather-- > autumn rain
            else if (temp >= 10 && temp < 20)
            {
                if (rain == "yes")
                {
                    Console.WriteLine("Autumn weather");
                }
                else
                {
                    Console.WriteLine("Normal weather");
                }
            }
            else if (temp >= 20 && temp < 30)
            {
                if (rain == "yes")
                {
                    Console.WriteLine("Showers");
                }
                else
                {
                    Console.WriteLine("It's hot");
                }
            }
            else 
            {
                if (rain == "yes")
                {
                    Console.WriteLine("Tropical storm");
                }
                else
                {
                    Console.WriteLine("I'm melting ;)");
                }
            }
        }
    }
}
