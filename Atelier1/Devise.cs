using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Devise
    {
        private double solde;
        private static string Dev = "MAD";

        public Devise() { }
        public Devise(double s)
        {
            this.solde = s;
        }
        public void afficher()
        {
            Console.WriteLine("le solde est" + this.solde);
        }
        public static Devise operator +(Devise s, Devise S)
        {
            Devise D = new Devise(S.solde + s.solde);
            return D;


        }
        public static Devise operator -(Devise s, Devise S)
        {
            Devise D = new Devise(S.solde - s.solde);
            return D;

        }
        public static bool operator <(Devise s, Devise S)
        {

            return (s.solde < S.solde);
           

        }
        public static bool operator >(Devise s, Devise S)
        {

            return (s.solde > S.solde);
        }
    }
}
