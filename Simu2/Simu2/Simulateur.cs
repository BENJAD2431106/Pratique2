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

        }
        private void SimulerTransaction(List<Client> clients)
        {

        }
        private List<Client> GenererList()
        {
            List<Client> listClients = new List<Client>();
            for(int i = 0;i<20;i++)
            {
                listClients.Add(Factory.CreerClient());
            }

            return listClients;
        }
    }
}
