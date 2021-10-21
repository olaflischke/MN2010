using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Schnabeltier : Saeugetier, IEileger
    {
        public List<Ei> Eier { get; set; } = new List<Ei>();
        public double Gewicht { get; set; }

        public void EiLegen()
        {
            if (this.Gewicht>1000)
            {
                Ei ei = new Ei(this);
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }
        }

        public override void Saeugen()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Saeugetier
    {
        public abstract void Saeugen();
    }
}
