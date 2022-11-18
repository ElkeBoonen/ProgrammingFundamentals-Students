using System;

namespace IMS___Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                //twee manier voor 'crazy input', werken met return, of werken met throw
                /*if (number < 2)
                {
                    Console.WriteLine("crazy input");
                    return; //uitvoering stopt hier!
                }*/
                if (number < 2) throw new Exception();

                for (int i = 2; i < number; i++)
                {
                    /*int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0) count++;
                    }
                    if (count > 2) Console.Write(i + " "); //waarom? sowieso altijd deelbaar door 1 en zichzelf
                     */
                    bool prime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            // break; --> van zodra er een deler is kan je ook breaken (= stoppen met de lus)
                        } 
                    }
                    if (prime) Console.Write(i + " ");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input");
            }
        }
    }
}
