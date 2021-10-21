using Microsoft.VisualStudio.TestTools.UnitTesting;
using HistorischeKurseDal;
using System;
using System.Linq;

namespace TestProjekt
{
    [TestClass]
    public class ArchivTests
    {
        string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
        string url2 = @"C:\tmp\Grob II\repo\Daten\eurofxref-hist-90d.xml";

        [TestMethod]
        public void IstArchivInitialisierbar()
        {
            Archiv archiv = new Archiv(url);

            Console.WriteLine($"Erster Handelstag: {archiv.Handelstage.First().Datum:dd.MM.yy}");

            Assert.AreEqual(ZaehleHandelstagKnoten(url), archiv.Handelstage.Count);
        }

        private int ZaehleHandelstagKnoten(string url)
        {
            return 64;
        }
    }
}
