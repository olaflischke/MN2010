using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HistorischeKurseDal
{
    public class Handelstag
    {
        public Handelstag(XElement handelstagKnoten)
        {
            this.Datum = Convert.ToDateTime(handelstagKnoten.Attribute("time").Value);

            // this.Kurse = Hausaufgabe
        }

        public DateTime Datum { get; set; }
        public List<Kurs> Kurse { get; set; }
    }
}