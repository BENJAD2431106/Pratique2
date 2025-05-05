using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public class VTT : VehiculeMotorise
    {
        Roue Roue { get; set; }
        public VTT(string nom, string marque, double prix, Moteur moteur, Roue roue) : base(nom, marque, prix, moteur)
        {
            Roue = roue;
        }
        public VTT(string nom, string marque, double prix, Moteur moteur) : base(nom, marque, prix, moteur)
        {
            Roue = new Roue(17, "Michellin");
        }


        public override string ToString()
        {
            return base.ToString()+" & "+Roue;
        }
    }
}
