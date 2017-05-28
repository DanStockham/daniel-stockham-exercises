using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class PostageCalculatorTests
    {
        [TestMethod]
        public void PostalService1stTest()
        {
            PostalService1st testPostage1 = new PostalService1st();

            Assert.AreEqual(39.00, testPostage1.CalculateRate(200, 48));
            Assert.AreEqual(0.94, testPostage1.CalculateRate(20, 15));
            Assert.AreEqual(1.60, testPostage1.CalculateRate(40, 7));
        }

        [TestMethod]
        public void PostalService2ndTest()
        {
            PostalService2nd testPostage2 = new PostalService2nd();
            Assert.AreEqual(0.39, testPostage2.CalculateRate(20, 48), 2);
            Assert.AreEqual(0.9541, testPostage2.CalculateRate(203, 15), 2);
            Assert.AreEqual(0.16, testPostage2.CalculateRate(40, 7), 2);
        }

        [TestMethod]
        public void PostalService3rdTest()
        {
            PostalService3rd testPostage3 = new PostalService3rd();
            Assert.AreEqual(0.30, testPostage3.CalculateRate(20, 48), 2);
            Assert.AreEqual(0.05, testPostage3.CalculateRate(20, 15), 2);
            Assert.AreEqual(1.60, testPostage3.CalculateRate(40, 7), 2);
        }

        [TestMethod]
        public void FexEdTest()
        {
            FexEd testFexEd = new FexEd();
            Assert.AreEqual(20.00, testFexEd.CalculateRate(400, 40));
            Assert.AreEqual(25.00, testFexEd.CalculateRate(600, 15));
            Assert.AreEqual(28.00, testFexEd.CalculateRate(600, 50));
        }

        [TestMethod]
        public void SPUTest()
        {
            SPU testSPU1 = new SPU(0);
            SPU testSPU2 = new SPU(1);
            SPU testSPU3 = new SPU(2);

            Assert.AreEqual(0.19, testSPU1.CalculateRate(200, 3), 2);
            Assert.AreEqual(62.50, testSPU2.CalculateRate(500, 40), 2);
            Assert.AreEqual(71.25, testSPU3.CalculateRate(400, 38), 2);
        }
    }
}
