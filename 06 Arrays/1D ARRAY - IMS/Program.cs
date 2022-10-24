using System;

namespace _1D_ARRAY___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**********************************/
            /******** ARRAY AANMAKEN **********/
            /**********************************/

            //lege array aanmaakt met een bepaalde lengte
            int[] ints = new int[5];       //maak hem aan met 5 elementen
            string[] names = new string[4]; //maak hem aan met 4 elementen
            
            //elementen meegeven
            string[] strings = { "iman","amina","anouk","kenneth" };
            double[] doubles = { 1.3, -8.7, -9, 23.7 };

            /**********************************/
            /******** WAARDEN OPVRAGEN ********/
            /**********************************/

            //altijd via index!!
            Console.WriteLine("strings op 0: " + strings[0]);
            Console.WriteLine("names op 0: " + names[0]);
            Console.WriteLine("doubles op 2: " + doubles[2]);

            Console.WriteLine("lengte van names: " + names.Length);

            //Console.WriteLine("iets opvragen buiten grenzen: " + names[4]);
            //element ligt buiten grenzen --> index out of range!!!

            /**********************************/
            /******** WAARDEN INVULLEN ********/
            /**********************************/

            //altijd via index
            names[0] = "Tuur";
            names[1] = "Jan";
            names[2] = "Mies";
            names[3] = "Bob";

            Console.WriteLine("doubles op 0: " + doubles[0]);
            doubles[0] = 5.8;
            Console.WriteLine("doubles op 0: " + doubles[0]);

            /**********************************/
            /******** ARRAY OVERLOPEN *********/
            /**********************************/

            //foreach is makkelijkste structuur --> alleen als je index niet nodig hebt!
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            //for is ook makkelijk --> als je index nodig hebt
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (double item in doubles)
            {
                Console.WriteLine(item);
            }

            //while blijf je beter af, altijd angst voor oneindige loop!!
            int index = 0;
            while (index < ints.Length)
            {
                Console.WriteLine($"op {index} staat {ints[index]}");
                index++;
            }

            /**********************************/
            /**** ARRAY OPGEVULD MET LUS ******/
            /**********************************/

            //ints-array opvullen met waarde afhankelijk van index
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i * 3;
            }

            Console.WriteLine("\nInts na opvullen");
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            //ints-array opvullen met waarde afhankelijk van index
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write($"Geef waarde voor index {i}: ");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nInts na opvullen door gebruiker");
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }

            /**********************************/
            /**** ARRAY OPVULLEN MET SPLIT ****/
            /**********************************/
            Console.WriteLine("\nGeef een reeks landen in, gesplitst door een spatie");
            string answer = "België Nederland Frankrijk Spanje Zwitserland Oostenrijk";//Console.ReadLine();

            string[] countries = answer.Split(' '); //zal string splitsen op een bepaald karakter en maakt een array
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGeef een reeks dieren in, gesplitst door een komma");
            answer = "KAT,OLIFANT,HOND,GIRAF";//Console.ReadLine();
            string[] animals = answer.Split(',');
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            /**********************************/
            /* INT ARRAY OPVULLEN MET SPLIT ***/
            /**********************************/
            Console.WriteLine("Geef een reeks ints in, gesplitst door een spatie: ");
            answer = "8 1 2 8 7 4 5 10 9 2 34 2";//Console.ReadLine();

            string[] strArray = answer.Split(' ');
            int[] intArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++) //kan ook intArray.Length (zijn toch even groot)
            {
                intArray[i] = Convert.ToInt32(strArray[i]);
            }

            //fancy methode
            int[] intArray2 = Array.ConvertAll(strArray, Convert.ToInt32);

            /**********************************/
            /*********** ARRAY METHODES *******/
            /**********************************/

            Array.Sort(intArray);
            Array.Reverse(intArray);
            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
