using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu2
{
    public enum Type
    {
        JetSki,
        SeaDoo
    }
    public class MotoMarine : VehiculeMotorise
    {
        Type Type {  get; set; }
        public MotoMarine(string nom, string marque, double prix, Moteur moteur) : base(nom, marque, prix, moteur)
            { Type = Type.SeaDoo; }
        public override string ToString()
        {
            return Type+" "+base.ToString();
        }
    }
}
