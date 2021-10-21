using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public abstract class Gefluegel : IEileger
    {
        public event EventHandler EigenschaftGeaendert;

        private void OnEigenschaftGeaendert()
        {
            if (EigenschaftGeaendert != null)
            {
                EigenschaftGeaendert(this, new EventArgs());
            }
        }

        //public Gefluegel()
        //{
        //    this.Id = Guid.NewGuid();
        //}

        /// <summary>
        /// Gibt das Gewicht des Tiers zurück oder legt es fest.
        /// </summary>
        /// <remarks>
        /// Das Gewicht eines Tiers darf nicht negativ sein.
        /// Dies wird von dieser Property nicht überprüft!
        /// </remarks>
        private double _gewicht;

        public double Gewicht
        {
            get { return _gewicht; }
            set
            {
                _gewicht = value;
                OnEigenschaftGeaendert();
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnEigenschaftGeaendert(); }
        }

        public Guid Id { get; set; } = Guid.NewGuid();


        public List<Ei> Eier { get; set; } = new List<Ei>();

        public abstract void EiLegen();
        public abstract void Fressen();
    }
}
