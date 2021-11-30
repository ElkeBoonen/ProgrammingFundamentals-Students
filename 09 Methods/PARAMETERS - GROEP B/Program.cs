using System;

namespace PARAMETERS___GROEP_B
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

        //static int getal = 5;
        static void Methode(int getal)
        {
            getal = 3;
            Console.WriteLine("in methode: " + getal);
        }

        static void Methode(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 10;
            }
            Console.Write("in methode: ");
            Print(array);
        }

        static void MethodeRef(ref int getal)
        {
            getal = 3;
            Console.WriteLine("in methode REF: " + getal);
        }

        static void MethodeOut(out int getal)
        {
            getal = 0;
            Console.WriteLine("in methode OUT: " + getal);
        }

        static void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void SwapRef(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void SwapOut(out int a, out int b)
        {
            a = 100;
            b = 50;

            int c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            int getal = 5;
            Console.WriteLine("in main: " + getal);
            Methode(getal);
            Console.WriteLine("in main: " + getal);

            int[] array = { 1, 2, 3 };
            Console.Write("in main: ");
            Print(array);
            Methode(array);
            Console.Write("in main: ");
            Print(array);

            getal = 5;
            Console.WriteLine("in main: " + getal);
            MethodeRef(ref getal);
            Console.WriteLine("in main: " + getal);

            getal = 5;
            Console.WriteLine("in main: " + getal);
            MethodeOut(out getal);
            Console.WriteLine("in main: " + getal);

            Console.WriteLine();

            int a = 10;
            int b = 5;
            Console.WriteLine($"a:{a} - b:{b}");
            Swap(a,b);
            Console.WriteLine($"a:{a} - b:{b}");

            Console.WriteLine($"a:{a} - b:{b}");
            SwapRef(ref a, ref b);
            Console.WriteLine($"a:{a} - b:{b}");

            Console.WriteLine($"a:{a} - b:{b}");
            SwapOut(out a, out b);
            Console.WriteLine($"a:{a} - b:{b}");

            Console.Write("Geef een getal in: ");
            string invoer = Console.ReadLine();

            bool gelukt = Int32.TryParse(invoer, out getal);
            Console.WriteLine($"{gelukt} met waarde {getal}");
        }
    }
}
