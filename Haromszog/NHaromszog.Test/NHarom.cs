﻿using System;
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

        [Test]
        public void AoldalKivetel()
        {
            var ex = Assert.Throws<HaromszogHiba>(()=>new DHaromszog("0 4 5"));
            Assert.AreEqual("Az a oldal nem lehet nulla negatív!",ex.Message);
        }

        [Test]
        public void BoldalKivetel()
        {
            var ex = Assert.Throws<HaromszogHiba>(()=>new DHaromszog("3 0 5"));
            Assert.AreEqual("A b oldal nem lehet nulla negatív!",ex.Message);
        }

        [Test]
        public void ColdalKivetel()
        {
            var ex=Assert.Throws<HaromszogHiba>(()=>new DHaromszog("3 4 0"));
            Assert.AreEqual("A c oldal nem lehet nulla negatív!", ex.Message);
        }

        //Egyéb kivételek tesztjei

    }
}