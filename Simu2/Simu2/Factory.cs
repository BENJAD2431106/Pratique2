using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    static class Factory
    {
        public static Client CreerClient(int i=0)
        {
            Random random = new Random();
            double nbre = random.Next(5000, 50000);
            int rndm = random.Next(0, 6);
            string[] noms = { "Jacob Martin", "Lydia Sanchez", "Nathalie Temblay", "Nadia Turcotte", " Alyson Fortin", "Corentin Simard" };
            return new Client(noms[i], nbre);

        }
    }
}
