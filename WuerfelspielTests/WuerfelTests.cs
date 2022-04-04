using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void WurfelBauen()
        {
            //arrage
            Wuerfel w = new Wuerfel(6);

            //act
            Assert.IsNotNull(w);

        }

        [TestMethod]
        public void SeitenSpeichern()
        {
            //arrage
            Wuerfel w = new Wuerfel(6);

            //act
            Assert.IsTrue(w.AnzahlSeiten == 6);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MehrAlsEineSeite()
        {
            //arrage
            Wuerfel w = new Wuerfel(-1);

            //act
        }

        [TestMethod]
        public void ZufallsZahlErstellet()
        {
            //arrage
            Wuerfel w = new Wuerfel(6);

            //act
            w.Wuerfeln();
            
            //Assert
            Assert.IsNotNull(w.Ergebnis);
        }

        //TODO: wie kann hier verhindert werden, dass der Random nur zufällig im Testbereich liegt?
        [TestMethod]
        public void ZufallMussAufDemWuerfelSein()
        {
            //arrage
            Wuerfel w = new Wuerfel(6);

            //act
            w.Wuerfeln();

            //Assert
            Assert.IsTrue(w.Ergebnis > 0 && w.Ergebnis < 7);
        }

        [TestMethod]
        public void Wuerfel_StandartKonstruktorIstKorrekt()
        {
            //arrage
            int anzahlSeiten = 6;
            int letztesErgebnis = 0;

            //act
            Wuerfel w = new Wuerfel();

            //Assert
            Assert.IsTrue(w.AnzahlSeiten == anzahlSeiten && w.LetztesErgebnis == letztesErgebnis);
           
        }
    }
}
