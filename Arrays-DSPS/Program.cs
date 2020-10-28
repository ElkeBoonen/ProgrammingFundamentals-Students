using System;

namespace Arrays_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            names[0] = "tuur";
            names[1] = "jan";
            names[2] = "mies";
            names[3] = "bob";

            //string name1 = "tuur"
            //string name2 = "jan"...

            int[] ages = { 13, 10, 9, 7 };
            ages[1] = 11;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + ": " + ages[i] + " years old");
            }


            Console.Write("Number of students: ");
            int nr = Convert.ToInt32(Console.ReadLine()) ;
            string[] students = new string[nr];
            for (int i = 0; i < nr; i++) // nr --> students.Length
            {
                Console.Write("Student " + (i+1) + ": "); //i++ != i+1 ==> i++ == i=i+1
                students[i] = Console.ReadLine();
            }

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }

            double[] grades = new double[nr];
            for (int i = 0; i < nr; i++) // nr --> students.Length
            {
                Console.Write("Grade for " + students[i] + ": ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Give all students (separated by a space)");
            students = Console.ReadLine().Split(' ');

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Give all lengths (separated by a ;)");
            string[] str_lengths = Console.ReadLine().Split(';');
            int[] lengths = new int[str_lengths.Length];
            for (int i = 0; i < str_lengths.Length; i++)
            {
                lengths[i] = Convert.ToInt32(str_lengths[i]);
            }

            foreach (var item in lengths)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Give all nrs (separated by a ,)");
            int[] nrs = Array.ConvertAll(Console.ReadLine().Split(','), Int32.Parse);
            foreach (var item in nrs)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < nrs.Length; i++)
            {
                for (int j = 0; j < nrs.Length-i-1; j++)
                {
                    if (nrs[j] > nrs[j + 1])
                    {
                        int temp = nrs[j];
                        nrs[j] = nrs[j + 1];
                        nrs[j + 1] = temp;
                    }
                }    
            }

            foreach (var item in nrs)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Array.Reverse(nrs); //Array.Sort!
            foreach (var item in nrs)
            {
                Console.Write(item + " ");
            }
            

            int[,] table = new int[2, 4];
            Console.WriteLine("Nr of elements inside table: " + table.Length);

            table[0, 3] = 7;
            table[1, 2] = 3;

            for (int i = 0; i < table.GetLength(0); i++) //rows
            {
                for (int j = 0; j < table.GetLength(1); j++) //cols
                {
                    Console.Write("Element on position " + i + " " + j + ": ");
                    table[i, j] = Convert.ToInt32(Console.ReadLine());
              }
            }

            for (int i = 0; i < table.GetLength(0); i++) //rows
            {
                for (int j = 0; j < table.GetLength(1); j++) //cols
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (var item in table)
            {
                sum += item; //sum = sum + item
            }
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("average: " + sum/table.Length);
            

            string[][] soccer = new string[3][];

            soccer = new string[][] { new string[] { "emma", "emily", "jane", "hannah"},
                                      new string[] { "taylor", "rachel", "phoebe"},
                                      new string[] { "monica", "isabella", "sofia"} };

            for (int i = 0; i < soccer.GetLength(0); i++)
            {
                Console.Write("Add players on row " + (i + 1 + " (separated by space): "));
                soccer[i] = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("Our soccer team!");
            for (int i = 0; i < soccer.GetLength(0); i++)
            {
                for (int j = 0; j < soccer[i].Length; j++)
                {
                    Console.Write(soccer[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            string word = "programming"; //1010111000
            char[] c = word.ToCharArray();
            foreach (var item in c)
            {
                Console.Write(item + " ");
            }

            char[] bin = "1010111000".ToCharArray();
            for (int i = 0; i < bin.Length; i++)
            {
                //if (bin[i]=='1')
            }
        }
    }
}
