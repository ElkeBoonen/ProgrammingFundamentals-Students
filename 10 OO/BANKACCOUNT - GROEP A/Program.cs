using System;
using System.Collections.Generic;

namespace BANKACCOUNT___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bankaccount> accounts = new List<Bankaccount>();

            Console.WriteLine("What do you want to do? \n" +
                "Press 1 to open an account\n" +
                "Press 2 to deposit money\n" +
                "Press 3 to withdraw money\n" +
                "Press 4 to print transactions");
            string answer = Console.ReadLine();

            while (true)
            {
                string name;
                double amount;
                switch (answer)
                {
                    case "1":
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Balance: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        accounts.Add(new Bankaccount(name, amount));
                        break;
                    case "2":
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        foreach (var item in accounts)
                        {
                            if (item.Owner == name) { item.Deposit(amount); }
                        }
                        break;
                    case "3":
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            accounts.Find(item => item.Owner == name).Withdraw(amount);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "4":
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine(accounts.Find(item => item.Owner == name).ToString());
                        break;
                    default:
                        return;
                }

                Console.WriteLine("\n\nWhat do you want to do? \n" +
                   "Press 1 to open an account\n" +
                   "Press 2 to deposit money\n" +
                   "Press 3 to withdraw money\n" +
                   "Press 4 to print transactions");
                answer = Console.ReadLine();


            }

            

        }
    }
}
