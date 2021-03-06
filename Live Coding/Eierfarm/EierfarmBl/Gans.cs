using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Gans : Gefluegel
    {

        public override void EiLegen()
        {
            if (this.Gewicht>2000)
            {
                Ei ei = new Ei(this);
                this.Eier.Add(ei);
                this.Gewicht -= ei.Gewicht;
            }
        }

        public override void Fressen()
        {
            if (this.Gewicht<5000)
            {
                this.Gewicht += 250;
            }
        }

        public int Steuerkurs { get; set; }
    }
}
