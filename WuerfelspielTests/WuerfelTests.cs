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

    }
}
