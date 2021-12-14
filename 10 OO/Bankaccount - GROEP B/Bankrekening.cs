using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount___GROEP_B
{
    class Bankrekening
    {
        public double Saldo { get; set; }
        //public double Intrest { get; set; }
        public string Eigenaar { get; set; }

        public Bankrekening(string eigenaar,double saldo)
        {
            Saldo = saldo;
            //Intrest = intrest;
            Eigenaar = eigenaar;
            Transactie("OPENING", saldo);
        }

        public double Storten(double geld)
        {
            Saldo += geld;
            Transactie("STORTING", geld);
            return Saldo;
        }

        public double Afhalen(double geld)
        {
            if (geld > 2500) 
            {
                throw new Exception("Limiet overschreden bij afhaling!");
            }
            if (geld > Saldo)
            {
                throw new Exception("U kan niet onder 0 gaan!");
            }
            Saldo -= geld;
            Transactie("AFHALING", geld);
            return Saldo;
        }

        private void Transactie(string transactie, double geld)
        {
            StreamWriter stream = new StreamWriter(Eigenaar + "_transacties.txt", true);
            stream.WriteLine(DateTime.Now + " " + transactie + " " + geld + " nieuw saldo = " + Saldo);
            stream.Close();
        }

        public override string ToString()
        {
            string s = "REKENING VAN " + Eigenaar + "\n";
            StreamReader stream = new StreamReader(Eigenaar + "_transacties.txt");
            s += stream.ReadToEnd();
            stream.Close();
            return s;
        }
    }
}
