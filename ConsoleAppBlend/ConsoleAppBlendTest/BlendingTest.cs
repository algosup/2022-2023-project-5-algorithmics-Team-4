using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppBlend.Tests
{
    [TestFixture]
    public class BlenderTests
    {
        [Test]
        public void Test_Initialisation_BlendingTank()
        {
            var c = 500;
            BlendingTank tank = new BlendingTank { capacity = c, quantity = 0 };


            // Vérifier que la capacité du réservoir est correcte
            Assert.AreEqual(500, tank.capacity);

            // Vérifier que la quantité initiale est de 0
            Assert.AreEqual(0, tank.quantity);
        }

        [Test]
        public void Test_Initialisation_WineTank()
        {
            var c = 500;
            var q = 100;
            var v = "A";
            var r = 0.5;
            WineTank tank = new WineTank { capacity = c, quantity = q, variety = v, ratio = r };

            // Vérifier que la capacité du réservoir est correcte
            Assert.AreEqual(500, tank.capacity);

            // Vérifier que la quantité initiale est correcte
            Assert.AreEqual(100, tank.quantity);

            // Vérifier que le nom du réservoir est correct
            Assert.AreEqual("A", tank.variety);

            // Vérifier que le ratio du réservoir est correct
            Assert.AreEqual(0.5, tank.ratio);
        }
    }
}
