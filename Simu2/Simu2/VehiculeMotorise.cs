using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class VehiculeMotorise
    {
        string Nom {  get; set; }
        string Marque { get; set; }
        public double Prix { get; set; }
        Moteur Moteur { get; set; }

        protected VehiculeMotorise(string nom, string marque, double prix, Moteur moteur)
        {
            Nom = nom;
            Marque = marque;
            Prix = prix;
            Moteur = moteur;
        }
        public override string ToString()
        {
            return "Véhicule " + Nom + " de marque " + Marque + ", prix : " + Prix + " & Moteur : " + Moteur;
        }
    }
}
