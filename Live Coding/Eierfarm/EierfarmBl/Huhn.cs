using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Huhn
    {
        public Huhn(string name)
        {
            this.Name = name;
            this.Gewicht = 1000;
            this.Id = Guid.NewGuid();
        }

        public void Fressen()
        {
            if (this.Gewicht <= 3000)
            {
                // this.Gewicht = this.Gewicht + 100;
                this.Gewicht += 100;
            }
        }

        public void EiLegen()
        {
            if (this.Gewicht>1500 && !this.Eier.Any(ei => DateTime.Now < ei.Legedatum.AddHours(3)))
            {
                Ei ei = new Ei();
                this.Gewicht -= ei.Gewicht;
                this.Eier.Add(ei);
            }

        }

        //public DateTime LetztesEiLegen { get; set; }
        public double Gewicht { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }

        public List<Ei> Eier { get; set; }
    }
}

