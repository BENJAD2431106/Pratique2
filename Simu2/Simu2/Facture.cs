using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class Facture
    {
        string Nom {  get; set; }
        Client Client { get; set; }
        DateTime Date { get; set; }
        VehiculeMotorise Vehicule {  get; set; }
        public Facture(string nom, Client client, VehiculeMotorise vehicule)
        {
            Nom = nom;
            Client = client;
            Vehicule = vehicule;
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            if (Vehicule is VTT)
            {
                return "Facture : " + Date + " -> " + Client + " achète " + Vehicule.ToString();
            }
            else
            {
                return "Facture : " + Date + " -> " + Client + " achète " + Vehicule.ToString();
            }
        }
    }
}
