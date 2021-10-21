using System;

namespace EierfarmBl
{
    public class Ei
    {
        // Irgendwo anders:
        // Ei ei = new Ei();
        public Ei(IEileger mutter)
        {
            this.Mutter = mutter;

            this.Legedatum = DateTime.Now;

            Random random = new Random();
            this.Gewicht = random.Next(45, 81);
            this.Farbe = (EiFarbe)random.Next(Enum.GetNames(typeof(EiFarbe)).Length);
            // DirectCast - liefert Exception wenn Cast fehlschlägt
        }
        // Ei ei=new Ei(50);
        public Ei(int gewicht)// : this()
        {
            this.Gewicht = gewicht;
        }
        // Backing Field für die Gewicht-Property
        private double _gewicht;

        // Full-qualified Property (propfull)
        // Property mit Backing Field
        public double Gewicht
        {
            get { return _gewicht; }  // double g = meinEi.Gewicht
            set
            {
                if (value <= 0)
                {
                    throw new Exception();
                }
                _gewicht = value;
            } // meinEi.Gewicht = value
        }

        // Auto-Property
        // Property mit automatisch (durch den Compiler)
        // generiertem Backing Field
        public int Id { get; private set; }

        public DateTime Legedatum { get; set; }
        public EiFarbe Farbe { get; set; }
        public IEileger Mutter { get; set; }
    }

    public enum EiFarbe
    {
        Hell,
        Dunkel,
        Gruen
    }
}
