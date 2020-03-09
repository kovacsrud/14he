using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlapMuveletek;

namespace Alap.Test
{
    [TestClass]
    public class Tesztek
    {
        [TestMethod]
        public void OsszeadTest()
        {
            //Arrange -> létrehozó műveletek
            AlapMuvelet muvelet = new AlapMuvelet();

            //Act
            //Műveletek végrehajtása
            var eredmeny = muvelet.Osszead(10, 10);
            //Assert -> eredmények összehasonlítása
            Assert.IsNotNull(eredmeny);
            Assert.AreEqual(20, eredmeny);
        }

        [TestMethod]
        public void KivonTest()
        {
            AlapMuvelet muvelet = new AlapMuvelet();
            Assert.IsNotNull(muvelet);
            Assert.AreEqual(10, muvelet.Kivon(20, 10));
        }

        [TestMethod]
        public void SzorozTest()
        {
            AlapMuvelet muvelet = new AlapMuvelet();
            Assert.IsNotNull(muvelet);
            Assert.AreEqual(100, muvelet.Szoroz(10, 10));
        }

        [TestMethod]
        public void OsztTeszt()
        {
            AlapMuvelet muvelet = new AlapMuvelet();
            Assert.IsNotNull(muvelet);
            Assert.AreEqual(10, muvelet.Oszt(100, 10));
        }
    }
}
