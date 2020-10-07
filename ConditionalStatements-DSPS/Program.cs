using System;

namespace ConditionalStatements_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Password? ");
            string password = Console.ReadLine();

            if (password == "test123") {
                Console.WriteLine("OK");
            }
            else if (password == "123test"){
                Console.WriteLine("OK");
            }
            else {
                Console.WriteLine("WRONG!!");
            }


            //wrong variation
            if (password == "test123"){
                Console.WriteLine("OK");
            }
            if (password == "123test"){
                Console.WriteLine("OK");
            }
            else{
                Console.WriteLine("WRONG!! -- 2nd if");
            }

            //variation 2
            if (password == "test123")
            {
                Console.WriteLine("OK");
            }
            else {
                if (password == "123test")
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("WRONG!!");
                }
            }


            //variation 3
            if ((password == "test123") || (password == "123test"))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("WRONG!!");
            }


            //variation 4 - opposite of variation 3
            if ((password != "test123") && (password != "123test"))
            {
                Console.WriteLine("WRONG!!");
            }
            else
            {
                Console.WriteLine("OK");
            }


            //variation 5
            bool condition = (password == "test123") || (password == "123test");
            if (condition) // condition == TRUE
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("WRONG!!");
            }


            //variation 6
            if (!condition) // !TRUE == FALSE ---- !FALSE == TRUE
            {
                Console.WriteLine("WRONG");
            }
            else
            {
                Console.WriteLine("OK");
            }
            

            Console.Write("Age? ");
            string answer = Console.ReadLine();

            int age; // try to parse!!
            bool success = Int32.TryParse(answer, out age); // age will become 0

            //if it has been successfully parsed
            if (success)
            {
                if (age >= 18) //age > 17
                {
                    Console.WriteLine("ADULT");
                }
                else
                {
                    Console.WriteLine("MINOR");
                }
            }
            else //ELSE (it has NOT been successfully parsed)
            {
                Console.WriteLine("WRONG INPUT");
                return; //RETURN in main program = stop execution
            }


            if (age == 0) //age < 1
            {
                Console.WriteLine("fresh baby");
            }
            else if (age <= 2) //age < 3       //(age > 0 ) && (age < 3)       (age >= 1 ) && (age <= 2) 
            {
                Console.WriteLine("baby");
            }
            else if (age <= 5) // age < 6
            {
                Console.WriteLine("toddler");
            }
            else if (age <= 9)
            {
                Console.WriteLine("child");
            }
            else if (age <= 13)
            {
                Console.WriteLine("tween");
            }
            else if (age <= 17)
            {
                Console.WriteLine("teenager");
            }
            else
            {
                Console.WriteLine("adult");
            }


            if (age >= 18)
            { 
            }
            else if (age >= 14)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 10)
            {
                Console.WriteLine("tween");
            }
            else if (age >= 6)
            {
                Console.WriteLine("child");
            }
            else if (age >= 3)
            {
                Console.WriteLine("toddler");
            }
            else if (age >= 1)
            {
                Console.WriteLine("fresh baby");
            }
            else
            {
                Console.WriteLine("baby");
            }



            switch (age)
            {
                case 0: Console.WriteLine("fresh baby"); break;
                case 1: 
                case 2: Console.WriteLine("baby"); break;
                case 3: 
                case 4: 
                case 5: Console.WriteLine("toddler"); break;
                case 6:
                case 7:
                case 8:
                case 9: Console.WriteLine("child"); break;
                case 10:
                case 11:
                case 12:
                case 13: Console.WriteLine("tween"); break;
                case 14:
                case 15:
                case 16:
                case 17: Console.WriteLine("teenager"); break;
                default: Console.WriteLine("adult"); break; //we always need a default case in a switch
            }



        }

    }
}
