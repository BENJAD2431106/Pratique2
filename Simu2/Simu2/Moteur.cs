using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public enum Refroidissement
    {
        Air,
        Liquide
    }
    public class Moteur
    {
        string Marque {  get; set; }
        int Chevaux { get; set; }
        Refroidissement Refroidissement { get; set; }
        public Moteur(string marque, int chevaux, Refroidissement refroidissement)
        {
            Marque = marque;
            Chevaux = chevaux;
            Refroidissement = refroidissement;
        }
        public Moteur()
        {
            Marque = "Yamaha";
            Chevaux = 50;
            Refroidissement = Refroidissement.Air;
        }
        public override string ToString()
        {
            return "Moteur " + Marque + " : " + Chevaux + " Chevaux, avec un refroidissement à " + Refroidissement;
        }
        public static bool operator >(Moteur moteur1, Moteur moteur2)
        {
            return moteur1 > moteur2;
        }
        public static bool operator <(Moteur moteur1, Moteur moteur2)
        {
            return moteur1 < moteur2;
        }
    }
}
