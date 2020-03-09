using System;
using NUnit.Framework;
using Haromszog;

namespace NHaromszog.Test
{
    [TestFixture]
    public class NHarom
    {
        [Test]
        public void AoldalTest()
        {
            var sut = new DHaromszog("3 4 5");
            Assert.IsNotNull(sut);
            Assert.IsInstanceOf<DHaromszog>(sut);
        }

        [Test]
        public void KeruletTest()
        {
            var sut = new DHaromszog("3 4 5");
            Assert.IsNotNull(sut);
            Assert.AreEqual(12,sut.Kerulet);
        }

        [Test]
        public void TeruletTest()
        {
            var sut = new DHaromszog("3 4 5");
            Assert.IsNotNull(sut);
            Assert.AreEqual(6, sut.Terulet);
        }
    }
}