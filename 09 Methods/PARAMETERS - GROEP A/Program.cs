using System;

namespace PARAMETERS___GROEP_A
{
    class Program
    {
        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void WijzigWaarde(int a)
        {
            Console.WriteLine(" --> in methode voor wijziging: " + a);
            a *= 100;
            Console.WriteLine(" --> in methode na wijziging: " + a);

        }

        static void WijzigWaarde(int[] array)
        {
            Console.Write(" --> in methode voor wijziging: ");
            Print(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 100;
            }
            Console.Write(" --> in methode na wijziging: ");
            Print(array);
        }

        static void Main(string[] args)
        {
            int variabele = 5;
            Console.WriteLine("in main voor methode: " + variabele);
            WijzigWaarde(variabele);
            Console.WriteLine("in main na methode: " + variabele);

            int[] array = { 1, 2, 3 };
            Console.Write("in main voor methode: ");
            Print(array);
            WijzigWaarde(array);
            Console.Write("in main na methode: ");
            Print(array);

        }
    }
}
