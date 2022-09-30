using System;

namespace Extra_oefening___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int som = a + b;
            int product = a * b;
            int verschil = a - b;
            int intdeling = a / b;
            double deling = (double)a / b; //je moet maar 1 omvormen naar double

            Console.WriteLine($"De som is {som.ToString("0.00")}");
            Console.WriteLine($"Het verschil is {verschil:0.00}");
            Console.WriteLine($"Het product is {product:0.00}");
            Console.WriteLine($"De intdeling is {intdeling.ToString("0.00")}");
            Console.WriteLine($"De gewone deling is {deling:F}");



        }
    }
}
