using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Compte
    {
       private Client Client;
        private readonly int numc;
       private int Cpt;
       private Devise solde;

        public Compte() {
           
        }
        public Compte(Client c , Devise d)
        {
            this.numc=++this.Cpt;
            this.Client = c;
            this.solde = d;
            
           
        }
        public void afficher()
        {
            Console.WriteLine("les informarion du compte:"+this.numc);
            this.Client.afficher();
            this.solde.afficher();
            Console.ReadKey();            
        }
        public void Crediter(Devise D)
        {
            this.solde = this.solde + D;
        }
        public bool Debiter(Devise D)
        {
            Devise Plafond = new Devise(10);
           

            if (D < Plafond)
            {
                this.solde = this.solde - D;
                Console.WriteLine("done");
                Console.ReadKey();
                return true; 
            }
            else
            {
                Console.WriteLine("ERR:impossible d'effectuer ce retrait !");
                Console.ReadKey();
                return false;
            }
        }
        public bool transfererargent(Compte c, Devise D)
        {
            if (this.Debiter(D))
            {
                c.Crediter(D);
                return true;

            }
            else
            {
                Console.WriteLine("ERR:impossible d'effectuer le virement!");
                Console.ReadKey();
                return false;
            }
        }
    }
}
