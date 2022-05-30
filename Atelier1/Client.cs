using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Client
    {
        private readonly string nom;
        private readonly string prenom;
        private readonly string adresse;

        public Client() { }
        public Client(string n , string p , string ad) {
            this.nom = n;
            this.prenom = p;
            this.adresse = ad;
        }
        public void afficher() {
            Console.WriteLine("les informations du Client :" + this.nom + "\n" + this.prenom + "\n" + this.adresse + "\n");
                }
       
    }
}
