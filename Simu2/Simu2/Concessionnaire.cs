using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class Concessionnaire
    {
        public string Nom {  get; set; }
        public List <VehiculeMotorise> Vehicules { get; set; } 
        public double Montant { get; set; }
        public List <Facture> Factures { get; set; }
        public Concessionnaire()
        {
            Nom = "Concessionnaire J";
            Vehicules = new List <VehiculeMotorise>();
            Factures = new List <Facture>();
            RemplirInventaire();
        }
        public void AjouterVehicule(VehiculeMotorise vehicule)
        {
            Vehicules.Add(vehicule);
        }
        public void VendreVehicule(VehiculeMotorise vehicule,Client client)
        {
            try
            {
                if (client.Montant < vehicule.Prix)
                {
                    throw new Exception("Client " + client.NomComplet + " trop pauvre pour acheter -> " + vehicule.Nom);
                }
                else
                {
                    Facture facture = new Facture("Facture", client, vehicule);
                    Factures.Add(facture);
                }
                Montant += vehicule.Prix;
                Vehicules.Remove(vehicule);
                client.Montant -= vehicule.Prix;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public VehiculeMotorise TrouverMeilleur(VehiculeMotorise v1, VehiculeMotorise v2)
        {
            if (v1.Moteur > v2.Moteur)
            {
                return v1;
            }
            else
                return v2;
        }
        private void RemplirInventaire()
        {
            //MOTOMARINE
            Vehicules.Add(new MotoMarine("Spark", "BRP", 12000, new Moteur(),Type.JetSki));
            Vehicules.Add(new MotoMarine("Fred", "BRP", 19000, new Moteur("Yamaha",220, Refroidissement.Air)));
            Vehicules.Add(new MotoMarine("Spark GTI", "BRP", 16500, new Moteur()));
            Vehicules.Add(new MotoMarine("GTX 99443", "Yamaha", 23500, new Moteur()));
            //VTT
            Vehicules.Add(new VTT("Spark", "BRP", 12000, new Moteur()));
            Vehicules.Add(new VTT("Fred", "BRP", 19000, new Moteur("Yamaha", 370, Refroidissement.Air)));
            Vehicules.Add(new VTT("Spark GTI", "BRP", 156500, new Moteur()));
            Vehicules.Add(new VTT("GTX 99443", "Yamaha", 23500, new Moteur()));
            Vehicules.Add(new VTT("POLARIS", "Yamaha", 22000, new Moteur()));
            Vehicules.Add(new VTT("POLARIS", "BRP", 32000, new Moteur("Evo", 520, Refroidissement.Air)));
            Vehicules.Add(new VTT("POLARIS", "BRP", 196500, new Moteur()));
            Vehicules.Add(new VTT("POLARIS", "Yamaha", 21100, new Moteur()));

        }
        private string AfficherFacture()
        {
            string infos = "";
            foreach(Facture facture in Factures)
            {
                infos+=(facture+"\n");
            }
            return infos;
        }
        public override string ToString()
        {
            return "******************MON CONCESSIONAIRE : "+Nom+" **********************\n"+AfficherFacture();
        }
    }
}
