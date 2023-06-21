using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppBlend;

namespace ConsoleAppBlend.Tests
{
    [TestFixture]
    public class BlenderTests
    {
        [Test]
        public void Test_Initialisation_Empty_Tank()
        {
            var c = 500;
            Tank tank = new Tank { capacity = c, quantity = 0 };


            // Vérifier que la capacité du réservoir est correcte
            Assert.AreEqual(500, tank.capacity);

            // Vérifier que la quantité initiale est de 0
            Assert.AreEqual(0, tank.quantity);
        }

        [Test]
        public void Test_Initialisation_Full_Tank()
        {
            var c = 500;
            var q = 100;
            string[] v = { "A" };
            double[] r = { 0.5 };
            Tank tank = new Tank { capacity = c, quantity = q, varieties = v, ratios = r };

            // Vérifier que la capacité du réservoir est correcte
            Assert.AreEqual(500, tank.capacity);

            // Vérifier que la quantité initiale est correcte
            Assert.AreEqual(100, tank.quantity);

            // Vérifier que le nom du réservoir est correct
            Assert.AreEqual(v, tank.varieties);

            // Vérifier que le ratio du réservoir est correct
            Assert.AreEqual(r, tank.ratios);
        }
    }
}
