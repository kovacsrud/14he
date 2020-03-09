using System;
using NUnit.Framework;
using AlapMuveletek;

namespace NAlap.Test
{
    [TestFixture]
    public class NTesztek
    {
        [Test]
        [TestCase(10,10,20)]
        [TestCase(10, 20, 30)]
        [TestCase(20, 20, 40)]
        [TestCase(20.5, 20.48, 41)]
        public void NOsszeadTest(double a,double b,double elvart)
        {
            AlapMuvelet muvelet = new AlapMuvelet();
            Assert.IsNotNull(muvelet);
            Assert.AreEqual(elvart, muvelet.Osszead(a, b),0.02);

        }

        [Test]
        public void NOsztKivetel()
        {
            var sut = new AlapMuvelet();
            Assert.Throws<ArgumentException>(()=>sut.Oszt(10,0));
        }
    }
}