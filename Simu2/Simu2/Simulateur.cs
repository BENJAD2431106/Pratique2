using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class Simulateur
    {
        Random random = new Random();
        Concessionnaire monConcesionnaire;
        public Simulateur()
        {
            monConcesionnaire = new Concessionnaire();
        }

        public void Simuler()
        {
            List<Client> clients = GenererList();
            SimulerTransaction(clients);
            Console.WriteLine(monConcesionnaire);
        }
        private void SimulerTransaction(List<Client> clients)
        {
            foreach (Client client in clients)
            {
                try
                {
                    if (monConcesionnaire.Vehicules is null)
                    {
                        throw new Exception("Pas de véhicule dans votre concesionnaire.");
                    }
                    for (int i = 0; i < monConcesionnaire.Vehicules.Count; i++)
                    {
                        for (int j = 0; j < monConcesionnaire.Vehicules.Count; j++)
                        {
                            if ((monConcesionnaire.Vehicules[i] is VTT && monConcesionnaire.Vehicules[i] is VTT) || (monConcesionnaire.Vehicules[i] is MotoMarine && monConcesionnaire.Vehicules[j] is MotoMarine))
                            {
                                monConcesionnaire.VendreVehicule(monConcesionnaire.TrouverMeilleur(monConcesionnaire.Vehicules[i], monConcesionnaire.Vehicules[j]), client);
                            }
                            break;
                        }
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
        private List<Client> GenererList()
        {
            List<Client> listClients = new List<Client>();
            for (int i = 0; i < 6; i++)
            {
                listClients.Add(Factory.CreerClient(i));
            }

            return listClients;
        }
    }
}
