using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class Roue
    {
        int Taille {  get; set; }
        string Marque { get; set; }
        public Roue(int taille, string marque)
        {
            Taille = taille;
            Marque = marque;
        }
        public override string ToString()
        {
            return "Roue de marque " + Marque + " et de taille " + Taille;
        }
    }
}
