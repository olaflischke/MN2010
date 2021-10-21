using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    /// <summary>
    /// Stellt ein Huhn dar.
    /// </summary>
    public class Huhn : Gefluegel
    {
        /// <summary>
        /// Erzeugt eine neue Huhn-Instanz
        /// mit dem gg. Namen.
        /// </summary>
        /// <param name="name">Name des Huhn.</param>
        public Huhn(string name)
        {
            this.Name = name;
            this.Gewicht = 1000;
            this.Id = Guid.NewGuid();
        }

        public override void Fressen()
        {
            if (this.Gewicht <= 3000)
            {
                // this.Gewicht = this.Gewicht + 100;
                this.Gewicht += 100;
            }
        }

        public override void EiLegen()
        {
            if (this.Gewicht > 1500 && !this.Eier.Any(ei => DateTime.Now < ei.Legedatum.AddHours(3)))
            {
                Ei ei = new Ei(this);
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }

        }

        //public DateTime LetztesEiLegen { get; set; }

    }
}

