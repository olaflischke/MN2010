using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public interface IEileger
    {
        List<Ei> Eier { get; set; }
        double Gewicht { get; set; }

        void EiLegen();
    }
}
