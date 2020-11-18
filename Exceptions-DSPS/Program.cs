using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exceptions_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            int nr;

            bool ok = Int32.TryParse(answer, out nr);

            if (ok)
            {
                Console.WriteLine("Enter a filename");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    StreamReader file = File.OpenText(filename);
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                    file.Close();
                }
                else
                {
                    Console.WriteLine("Give a correct filename!");
                }
                
            }
            else
            {
                Console.WriteLine("Give a correct number!");
            }
            

            try
            {
                Console.WriteLine("Enter a number of lines: ");
                int nr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a filename");
                string filename = Console.ReadLine();

                StreamReader file = File.OpenText(filename);
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Oops! File was not found!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Oops! Number was not correct!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Oops! Number was too big!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Something went wrong! Try again!");
                Console.WriteLine(ex.Message);
            }
           

            StreamReader file = File.OpenText("english.txt");
            try
            {
                Console.WriteLine("Enter a number of lines: ");
                int nr = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Oops! Number was not correct!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Oops! Number was too big!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! Something went wrong! Try again!");
                Console.WriteLine(ex.Message);
            }
            finally {
                file.Close();
                Console.WriteLine("Finally! We close our file!");
            }
            */

            /*
             Check whether a certain password is strong or not. 
             A password must contain lower and upper case letters, symbols and numbers. 
             it must be at least 7 characters long.
             

            try
            {

                Console.WriteLine("Give three passwords (seperated by a space): ");
                string[] passwords = Console.ReadLine().Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    int check = 1;
                    if (passwords[i].Length >= 7) check++;
                    if (passwords[i].Any(char.IsUpper)) check++;
                    if (passwords[i].Any(char.IsLower)) check++;
                    if (passwords[i].Any(char.IsNumber)) check++;
                    if (passwords[i].Any(char.IsSymbol)) check++;
                    if (check == 5) Console.WriteLine(passwords[i] + " is strong" );
                    else Console.WriteLine(passwords[i] + " is weak");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("We need three passwords!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */

            try {
                string[] password = Console.ReadLine().Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    /* if anything with less than 7 characters 
                    * OR anything with no numbers 
                    * OR anything with no uppercase 
                    * OR anything with no special characters
                    */
                    string test = @"^(.{0,6}|[^0-9]*|[^A-Z]*|[a-zA-Z0-9]*)$";

                    //If anything matches that, then it’s an invalid password.
                    Match match = Regex.Match(password[i], test);
                    if (match.Success)
                    {
                        Console.WriteLine(password[i] + " is weak");
                    }
                    else
                    {
                        Console.WriteLine(password[i] + " is strong");
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("We need three passwords!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
