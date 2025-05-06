using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class Client
    {
        public string NomComplet { get; set; }
        public double Montant { get; set; }
        public Client(string nom, double mt)
        {
            NomComplet = nom;
            Montant = mt;
        }
        public override string ToString()
        {
            return "Client " + NomComplet + " qui a $$$: " + Montant;
        }
    }
}
