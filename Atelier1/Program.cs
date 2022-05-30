using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Program
    {
        static void Main(string[] args)
        {   Client c = new Client("n1", "c1", "ad1");
            Client c2 = new Client("n2", "c2", "ad2");
            Devise d = new Devise(10000);
            Devise cr = new Devise(5000);
            Devise pl = new Devise(3000);
            Compte C = new Compte(c, d);
            Compte C2 = new Compte(c2, pl);
            C.afficher();
            C2.afficher();
            C.Debiter(cr);
            C.transfererargent(C2, cr);
            C.afficher();
            C2.afficher();
        }
    }
}
