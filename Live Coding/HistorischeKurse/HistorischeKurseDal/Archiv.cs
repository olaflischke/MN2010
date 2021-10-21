using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace HistorischeKurseDal
{
    public class Archiv
    {
        public Archiv(string url)
        {
            this.Handelstage = HoleDaten(url);
        }

        private List<Handelstag> HoleDaten(string url)
        {
            //List<Handelstag> tage = new List<Handelstag>();
            XDocument document = XDocument.Load(url);

            var q = from xe in document.Root.Descendants()
                    where xe.Name.LocalName == "Cube" && xe.Attributes().Any(at => at.Name == "time")
                    // Projektion
                    select new Handelstag(xe);
                    //{
                    //    Datum = Convert.ToDateTime(xe.Attribute("time").Value)
                    //};

            return q.ToList();

            //foreach (XElement item in q)
            //{
            //    Handelstag handelstag = new Handelstag()
            //    {
            //        Datum = Convert.ToDateTime(item.Attribute("time").Value)
            //    };
            //    tage.Add(handelstag);
            //}

            //return tage;
        }

        private List<Handelstag> HoleDatenMitXmlReader(string url)
        {
            List<Handelstag> tage = new List<Handelstag>();

            XmlReader reader = XmlReader.Create(url);

            while (reader.Read())
            {
                if (reader.Name == "Cube")
                {
                    Handelstag handelstag = null;

                    if (reader.AttributeCount == 1)
                    {
                        // Handelstag
                        handelstag = new Handelstag();
                        handelstag.Datum = Convert.ToDateTime(reader.GetAttribute("time"));
                        tage.Add(handelstag);
                    }
                    else if (reader.AttributeCount == 2)
                    {
                        // Kurs
                        Kurs kurs = new Kurs();
                        kurs.Waehrung = reader.GetAttribute("currency");
                        kurs.Eurokurs = Convert.ToDouble(reader.GetAttribute("rate"));
                        handelstag.Kurse.Add(kurs);
                    }
                }
            }
            return tage;
        }

        public List<Handelstag> Handelstage { get; set; }
    }
}
