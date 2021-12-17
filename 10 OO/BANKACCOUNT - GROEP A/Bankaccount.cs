using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BANKACCOUNT___GROEP_A
{
    class Bankaccount
    {
        public string Owner { get; set; }
        public double Balance { get; set; }
        private string _filename;

        public Bankaccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;

            Regex regex = new Regex(@"[^a-zA-Z]");
            string replace = regex.Replace(owner, "_");
            _filename = "transactions_" + replace + ".txt";

            if (File.Exists(_filename))
            {
                string[] transactions = File.ReadAllLines(_filename);
                string last = transactions[transactions.Length - 1];
                //Deposit money 100 new balance = 1100
                string[] parts = last.Split('=');
                double oldbalance = Convert.ToDouble(parts[parts.Length - 1].Trim());
                Balance = oldbalance;
                Deposit(balance);
            }
            else
            {
                Transaction("Open account");
            }
        }

        private void Transaction(string message)
        {
            StreamWriter stream = new StreamWriter(_filename,true);
            stream.WriteLine(DateTime.Now + " " + message + " new balance = " + Balance);
            stream.Close();
        }

        public double Deposit(double money)
        {
            Balance += money;
            Transaction("Deposit money " + money);
            return Balance;
        }

        public double Withdraw(double money)
        {
            if (money > 500) 
            {
                throw new Exception("Daylimit exceeded!");
            }
            if (money > Balance + 1000)
            {
                throw new Exception("Stop buying stupid things!");
            }
            Balance -= money;
            Transaction("Withdraw money " + money);
            return Balance;
        }

        public override string ToString()
        {
            string s = "BANKACCOUNT " + Owner + "\n";
            foreach (var item in File.ReadAllLines(_filename))
            {
                s += " -" + item + "\n";
            }
            return s;
        }
    }
}
