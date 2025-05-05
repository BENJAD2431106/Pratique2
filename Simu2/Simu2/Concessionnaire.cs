using System;
using System.Collections.Generic;
using System.Linq;
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

        }
        public void AjouterVehicule(VehiculeMotorise vehicule)
        {
            Vehicules.Add(vehicule);
        }
        public void VendreVehicule(VehiculeMotorise vehicule)
        {
            Montant += vehicule.Prix;
            Vehicules.Remove(vehicule);
        }
        private void RemplirInventaire()
        {
            //MOTOMARINE
            Vehicules.Add(new MotoMarine("Spark", "BRP", 12000, new Moteur()));
            Vehicules.Add(new MotoMarine("Fred", "BRP", 19000, new Moteur("Yamaha",220, Refroidissement.Air)));
            Vehicules.Add(new MotoMarine("Spark GTI", "BRP", 156500, new Moteur()));
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
    }
}
